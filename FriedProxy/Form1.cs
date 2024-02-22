using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

//namespace System.Runtime.CompilerServices
//{
//    internal static class IsExternalInit { }
//}
namespace FriedProxy
{
    public partial class Form1 : Form
    {
        public delegate void SafeLogDelegate(string text);
        private static bool Running = false;
        private static bool Capturing = false;
        public Form1()
        {
            InitializeComponent();
            ProxyHelper.FormRefference = this;
            ProxyHelper.ListRefference = this.lstbxPackets;
        }

        private void bttnStartStop_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                //stop the server
                lblProxyStatus.Text = "Stopping...";
                try 
                {
                    ProxyHelper.StopServer();
                    Running = false;
                    bttnStartStop.Text = "Start Proxy";
                    lblProxyStatus.Text = "Proxy is not running.";
                }
                catch (Exception ex)
                {
                    lblProxyStatus.Text = $"Error stopping proxy:{ex.Message}";
                }
            }
            else
            {
                //start the server
                lblProxyStatus.Text = "Starting...";
                this.Text = $"FriedProxy@{txtbxServerIP.Text}:{txtbxServerPort.Text} -> localhost:{txtbxLocalPort.Text}";
                ProxyHelper.InitServer();
                Running = true;
                bttnStartStop.Text = "Stop Proxy";
                lblProxyStatus.Text = $"Proxy is running, \nConnect to it using \"{ProxyHelper.remoteProxyAddress}:{ProxyHelper.remoteProxyPort}\"";
            }

            txtbxLocalPort.Enabled = !Running;
            txtbxServerIP.Enabled = !Running;
            txtbxServerPort.Enabled = !Running;

        }

        public class packet
        {
            public int Size;
            public byte[] Buffer;
            public bool FromServer;
            public packet(int size, byte[] buffer, bool fromServer) 
            {
                this.Size = size;
                this.Buffer = buffer;
                this.FromServer = fromServer;
            }
        }
        public List<packet> capturedPackets = new List<packet>();
        static int maxLogs = 20; // Maximum number of log entries to keep
        public int[] ignoredSizes = new int[] { };

        public void ReciveLog(string message, int Size = -1)
        {
            if (message.StartsWith("Forwarding "))
            {
                if (!chkbxFilterClient.Checked)
                    return;
            }
            else if (message.StartsWith("Got packet from server with "))
            {
                if (!chkbxFilterServer.Checked)
                    return;
            }
            if (ignoredSizes.Contains(Size)) return;

            //the actual implementation
            lstbxPackets.Items.Add(message);
            TrimExcessLogs();
        }
        public void TrimExcessLogs()
        {
            ListBox lst = lstbxPackets;
            //lstbxpack
            const int batchSize = 10; // Number of logs to remove at a time
            int excessCount = lst.Items.Count - maxLogs;

            if (excessCount > 0)
            {
                List<object> itemsToRemove = new List<object>();

                // Collect items to remove
                for (int i = 0; i < excessCount; i++)
                {
                    itemsToRemove.Add(lst.Items[i]);
                }

                // Remove collected items in a single operation
                foreach (object item in itemsToRemove)
                {
                    lst.Items.Remove(item);
                }
            }
        }
        public void RecivePacket(int size, byte[] buffer, bool fromServer)
        {
            if (Capturing)
            {
                bool deviceCorrect = (fromServer && chkbxServer.Checked) || (!fromServer && chkbxClient.Checked);

                if (!deviceCorrect) return;

                int min = (int)numMinimal.Value;
                int max = (int)numMaximal.Value;

                bool sizeCorrect = (size >= min) && (size <= max);

                if (!sizeCorrect) return;

                packet p = new packet(size, buffer, fromServer);
                capturedPackets.Add(p);
                string device = fromServer ? "server" : "client";
                lstbxCaptured.Items.Add($"From {device}, recived {size} bytes");
            }
        }

        private void StartCapturing() 
        {
            if (!Capturing)
            {
                lblCaptureStatus.Text = "Capturing started.";
                Capturing = true;
            }
            else
            {
                lblCaptureStatus.Text = "Already capturing";
            }
        }

        private void StopCapturing() 
        {
            if (Capturing)
            {
                lblCaptureStatus.Text = "Capturing stopped.";
                Capturing = false;
            }
            else
            {
                lblCaptureStatus.Text = "Already stopped.";
            }
        }

        private void startCapturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCapturing();
        }

        private void stopCapturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCapturing();
        }

        private void clearCapturedPacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstbxCaptured.Items.Clear();
            capturedPackets.Clear();
        }

        private void txtbxSizeFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ignoredSizes = txtbxSizeFilter.Text.Split('|').Select(i => Int32.Parse(i)).ToArray();
                lblSizeFilterPreview.Text = string.Join(", ", ignoredSizes);
            }
            catch
            {
                ignoredSizes = new int[] { };
                lblSizeFilterPreview.Text = "No filtering";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbxSizeFilter.Text = "28|12|36";
        }

        private void executeCapturedPacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProxyHelper.queue.Clear();
            ProxyHelper.queue.AddRange(capturedPackets);
        }
    }
}
