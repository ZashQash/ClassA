using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Client_GUI
{
    public partial class FrmClient : Form
    {
        private Socket sock;
        private Socket accept;
        public FrmClient()
        {
            InitializeComponent();
            sock = socket();
            FormClosing += FrmClient_FormClosing;
   
        }

        void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            sock.Close();
        }
        
        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sock.Connect(new IPEndPoint(IPAddress.Parse(txtbIP.Text), 1996));
                new Thread(() =>
                {
                    read();
                }).Start();

            }
            catch (Exception)
            {
                MessageBox.Show("CONNECTION FAILED!","Client");
                throw;
            }
        }

        void read()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[255];
                    int byteRead = sock.Receive(buffer);
                    if (byteRead <= 0)
                    {
                        throw new SocketException();
                    }
                    Array.Resize(ref buffer, byteRead);

                    Invoke((MethodInvoker)delegate
                    {
                        lstbDispaly.Items.Add(Encoding.Default.GetString(buffer));
                    });

                }
                catch (Exception)
                {
                    MessageBox.Show("DISCONNECTION","Client");
                    break;
                }
            }
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Default.GetBytes(txtbSend.Text);
            sock.Send(data, 0, data.Length, 0);
        }

    }
}
