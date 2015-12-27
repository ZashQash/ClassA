using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32.SafeHandles;
using System.IO;

namespace Test_ServerL4
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        Socket sock;
        Socket accept;
        private void btn_Click(object sender, EventArgs e)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(IPAddress.Any, 1990));
            sock.Listen(0);

            accept = sock.Accept();
            sock.Close();

            MemoryStream ms = new MemoryStream();

            #region ThreadStart
            new Thread(() =>
            {
                while (true)
                {
                    byte[] sizebyte = new byte[4];
                    accept.Receive(sizebyte, 0, sizebyte.Length, 0);
                    int size = BitConverter.ToInt32(sizebyte, 0);

                    while (size > 0)
                    {
                        byte[] buffer;
                        
                        buffer = size < accept.ReceiveBufferSize ? new byte[size] : new byte[accept.ReceiveBufferSize];
                        //if (size < accept.ReceiveBufferSize)
                        //{
                        //    buffer = new byte[size];
                        //}
                        //else
                        //{
                        //    buffer = new byte[accept.ReceiveBufferSize];
                        //}

                        int recByte = accept.Receive(buffer, 0, buffer.Length, 0);
                        size -= recByte;
                        ms.Write(buffer, 0, buffer.Length);
                    }
                    ms.Close();
                    byte[] data = ms.ToArray();
                    ms.Dispose();

                    Invoke((MethodInvoker) delegate
                    {
                        rtbDisplay.Text = Encoding.Default.GetString(data);
                    });
                }
            }).Start();
            #endregion
        }
    }
}
