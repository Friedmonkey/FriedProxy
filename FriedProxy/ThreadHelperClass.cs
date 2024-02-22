using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriedProxy
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form1 f, ListBox lst, string text, int size = -1);
        delegate void AddPacketCallback(Form1 f, ListBox lst, int size, byte[] buffer, bool fromServer);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="lst"></param>
        /// <param name="text"></param>
        public static void AddLog(Form1 form, ListBox lst, string text, int size = -1)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (lst.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddLog);
                form.Invoke(d, new object[] { form, lst, text, size });
            }
            else
            {
                form.ReciveLog(text, size);
            }
        }


        public static void AddPacket(Form1 form, ListBox lst, int size, byte[] buffer, bool fromServer)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (lst.InvokeRequired)
            {
                AddPacketCallback d = new AddPacketCallback(AddPacket);
                form.Invoke(d, new object[] { form, lst, size, buffer, fromServer });
            }
            else
            {
                form.RecivePacket(size, buffer, fromServer);
            }
        }
    }
}
