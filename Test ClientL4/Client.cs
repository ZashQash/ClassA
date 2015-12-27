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

namespace Test_ClientL4
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        Socket sck;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1990);
            
            try
            {
                sck.Connect(serverEndPoint);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to Connect Server", "Client");
                Application.Exit();
            }
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(rtbDispaly.Text);
            byte[] byteSize = BitConverter.GetBytes(buffer.Length);
            sck.Send(byteSize, 0, 4, 0);
            sck.Send(buffer, 0, buffer.Length, 0);
        }
    }
}
