using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_GUI
{
    public partial class frmServer : Form
    {
         private Socket sock;
        private Socket accept;
        public frmServer()
        {
            InitializeComponent();
        }
        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        
        private void btnListen_Click(object sender, EventArgs e)
        {
            sock = socket();

            sock.Bind(new IPEndPoint(IPAddress.Any/* 0 */, 1996));
            sock.Listen(0);

            new Thread(delegate ()
            {
                accept = sock.Accept();
                MessageBox.Show("CONNECTION ACCEPTED");
                sock.Close();

                try
                {
                    while (true)
                    {
                        byte[] buffer = new byte[255];
                        int readByte = sock.Receive(buffer, 0, buffer.Length, 0);

                        if (readByte <= 0)
                        {
                            throw new SocketException();
                        }

                        Array.Resize(ref buffer, readByte);

                        //Since we are accepting and receiving in new thread,
                        // if we run listbDispaly in this new thread, then it 
                        // will give error of "cross thread calls"
                        //So we are running the listbDispaly in main thread.
                        Invoke((MethodInvoker)delegate
                        {
                            lstbDisplay.Items.Add(Encoding.Default.GetString(buffer));
                        });
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("DISCONNECTION!");
                    Application.Exit();
                }

            }).Start();


        }
    }
}
