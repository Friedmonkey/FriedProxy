using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FriedProxy
{
    public partial class ProxyHelper
    {
        /// <summary>
        /// The server socket for the program
        /// </summary>
        private static Socket server;
        /// <summary>
        /// The size of the received buffer
        /// </summary>
        private const int bufferSize = 4096;
        /// <summary>
        /// The IPAddress this server if listening on
        /// </summary>
        private static IPAddress bindAddress = IPAddress.Any;
        /// <summary>
        /// The port, this server is listening on
        /// </summary>
        public const int bindPort = 25565;
        /// <summary>
        /// IP Address or DNS name of the remote proxy server
        /// </summary>
        //private const string remoteProxyAddress = "51.222.245.178"; //play.mcdiamondfire.com
        public const string remoteProxyAddress = "170.205.24.42"; //legitimoose.com
        /// <summary>
        /// Set to true if you specified a DNS name for the remote proxy server
        /// </summary>
        private const bool isDns = false; //Set the true if you defined a DNS name above
        /// <summary>
        /// The port of the remote proxy server
        /// </summary>
        public const int remoteProxyPort = 25565;
        /// <summary>
        /// The parsed IP based on what you specified
        /// </summary>
        private static IPAddress remoteIP = null;

        public static Form1 FormRefference = null;
        public static ListBox ListRefference = null;

        ///// <summary>
        ///// Application entry point
        ///// </summary>
        ///// <param name="args">The command line arguments</param>
        //static void Main(string[] args)
        //{
        //    InitServer(); //Start the local server
        //    WriteLine("Press enter to stop the proxy");
        //    ReadLine(); //Wait for [eneter]
        //    StopServer(); //Stop the server
        //}

        public static void WriteLineSafe(string msg, int size = -1) 
        {
            //ListRefference.Items.Add(msg);
            ThreadHelperClass.AddLog(FormRefference, ListRefference, msg, size);
        }

        public static void LogPacket(int size, byte[] bytes, bool fromServer)
        {
            //ListRefference.Items.Add(msg);
            ThreadHelperClass.AddPacket(FormRefference, ListRefference, size, bytes, fromServer);
        }

        //private void WriteTextSafe(string text)
        //{
        //    if (textBox1.InvokeRequired)
        //    {
        //        var d = new SafeCallDelegate(WriteTextSafe);
        //        textBox1.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        textBox1.Text = text;
        //    }
        //}

        /// <summary>
        /// Start the local proxy server
        /// </summary>
        public static void InitServer()
        {
            if (server != null) return; //If the server is already started, return
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Create a new server socket
            IPEndPoint ep = new IPEndPoint(bindAddress, bindPort); //Create a local end point for the server
            server.Bind(ep); //Bind the sokcet to our end point
            server.Listen(5); //Listen for incoming connections (max. 5 pending connections)
            server.BeginAccept(new AsyncCallback(AcceptClients), null); //Accept incoming connections
        }

        /// <summary>
        /// Stop the local server
        /// </summary>
        public static void StopServer()
        {
            if (server == null) return; //If the server isn't started, return
            WriteLineSafe("Stopping Proxy.");
            //Close and dispose the server socket
            server.Shutdown(SocketShutdown.Both);
            server.Disconnect(false);
            server.Close();
            server.Dispose();
            server = null;
        }

        /// <summary>
        /// Accept incoming connections
        /// </summary>
        /// <param name="ar">Async Result</param>
        private static void AcceptClients(IAsyncResult ar)
        {
            Socket browserSocket; //Define a new socket for the incoming client

            try
            {
                browserSocket = server.EndAccept(ar); //Get the socket of the new client
            }
            catch (Exception ex)
            {
                WriteLineSafe("Failed to accept client. Reason: " + ex.ToString());
                return;
            }

            WriteLineSafe("Connection Accepted");

            HandleClientBrowser(browserSocket); //Start handling the new client

            server.BeginAccept(new AsyncCallback(AcceptClients), null); //Re-start accepting clients
        }

        /// <summary>
        /// Message object for async calls
        /// </summary>
        private struct MsgObj
        {
            public Socket s; //The socket of the client
            public byte[] buffer; //The receive buffer
            public Socket p; //A socket to the remote proxy
        }

        /// <summary>
        /// Read response from the remote proxy server
        /// </summary>
        /// <param name="ar">Async Result</param>
        private static void ReadProxy(IAsyncResult ar)
        {
            try
            {
                MsgObj clients = (MsgObj)ar.AsyncState; //Get the message object

                int bytesRead = clients.p.EndReceive(ar); //Read response from the remote proxy
                if (bytesRead > 0)
                {
                    clients.s.BeginSend(clients.buffer, 0, bytesRead, SocketFlags.None, new AsyncCallback(DataSend), clients.s); //Send the response back to the client
                }

                clients.p.BeginReceive(clients.buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReadProxy), clients); //Re-start reading data from the remote proxy
            }
            catch (Exception ex)
            {
                WriteLineSafe("Error, reading from the remote proxy server, Reason: " + ex.ToString());
            }
        }

        public static List<Form1.packet> queue = new List<Form1.packet>();

        /// <summary>
        /// Read requests from the browsers
        /// </summary>
        /// <param name="ar">Async Result</param>
        private static void ReadClient(IAsyncResult ar)
        {
            MsgObj client = new MsgObj(); //Define a message object
            try
            {
                client = (MsgObj)ar.AsyncState; //Get the message object
                int bytesRead = client.s.EndReceive(ar); //Read request from client


                //just read this from the clint, now forwarding
                WriteLineSafe("Forwarding " + bytesRead + " bytes to server", bytesRead);
                if (bytesRead > 0)
                {
                    Socket toProxySocket; //Define a new socket to the remote proxy server
                    if (client.p == null) //Proxy socket not created
                    {
                        toProxySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Create a new socket
                        if (remoteIP == null) GetIpAddress(); //Parse the specified IPAddress if needed
                        IPEndPoint ep = new IPEndPoint(remoteIP, remoteProxyPort); //Create a new end point to the remote proxy
                        toProxySocket.Connect(ep); //Connect to the proxy
                        client.p = toProxySocket; //Set the proxy socket in the message object
                        MsgObj msg = new MsgObj() //Create a new message object
                        {
                            p = client.p,
                            s = client.s,
                            buffer = new byte[bufferSize]
                        };
                        client.p.BeginReceive(msg.buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReadProxy), msg); //Read response from proxy server
                        LogPacket(bytesRead, msg.buffer, false);

                    }
                    else toProxySocket = client.p; //PRoxy socket open
                    if (queue.Count() > 0)
                    {
                        var packet = queue.FirstOrDefault();
                        if (packet != null) 
                        {
                            queue.Remove(packet);
                            WriteLineSafe($"Executing packet of size {packet.Size}");
                            toProxySocket.Send(packet.Buffer, 0, packet.Size, SocketFlags.None); //Send the request to the remote proxy
                        }
                    }
                    toProxySocket.Send(client.buffer, 0, bytesRead, SocketFlags.None); //Send the request to the remote proxy
                    client.s.BeginReceive(client.buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReadClient), client); //Re-start reading from the client
                    LogPacket(bytesRead, client.buffer, false);
                }
            }
            catch (Exception ex)
            {
                WriteLineSafe("Error reading data from client, Reason: " + ex.ToString());
            }
        }

        /// <summary>
        /// Handle new incoming clients
        /// </summary>
        /// <param name="client">The socket of the new client</param>
        private static void HandleClientBrowser(Socket client)
        {
            try
            {
                MsgObj mo = new MsgObj() //Create a new message object for the client
                {
                    s = client,
                    buffer = new byte[bufferSize]
                };

                client.BeginReceive(mo.buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReadClient), mo); //Read requests from the browser
            }
            catch (Exception ex)
            {
                WriteLineSafe("Error: " + ex.ToString());
            }
        }

        /// <summary>
        /// Send response to the client
        /// </summary>
        /// <param name="ar">Async Result</param>
        private static void DataSend(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState; //Get the socket of the client

                //int buff = client.EndReceive(ar);


                int buff = client.EndSend(ar); //Send the data to the client

                WriteLineSafe($"Got packet from server with {buff} bytes, now forwarding to client", buff);
            }
            catch (Exception ex)
            {
                WriteLineSafe("Error, when sending data to client, Reason: " + ex.ToString());
            }
        }

        /// <summary>
        /// Parse the string ipaddress into an IPAddress object
        /// </summary>
        private static void GetIpAddress()
        {
            if (isDns) //If a DNS name is defined
            {
                try
                {
                    IPAddress[] ipAddresses = Dns.GetHostAddresses(remoteProxyAddress); //Resolve the DNS into IPAddresses
                    if (ipAddresses.Length < 1)
                    {
                        WriteLineSafe("Error, failed to lookup DNS name " + remoteProxyAddress);
                        WriteLineSafe("Press enter key to exit");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                    if (ipAddresses.Length > 1) WriteLineSafe("Warning, DNS lookup resulted in multiple IP adresses! Using the first one.");

                    remoteIP = ipAddresses[0]; //Get the first successful result from the resolve
                }
                catch (Exception ex)
                {
                    WriteLineSafe("Error, failed to lookup DNS name Reason: " + ex.ToString());
                    WriteLineSafe("Press enter key to exit");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
            else //Plain ipaddress defined
            {
                try
                {
                    remoteIP = IPAddress.Parse(remoteProxyAddress); //Parse the ipaddress defined
                }
                catch (Exception ex)
                {
                    WriteLineSafe("Error, failed to convert string to IP, Reason: " + ex.ToString());
                    WriteLineSafe("Press enter key to exit");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }
    }
}
