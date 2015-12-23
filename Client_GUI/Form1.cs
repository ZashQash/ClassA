using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_GUI
{
    public partial class FrmClient : Form
    {
        private Socket sock;
        private Socket accept;
        public FrmClient()
        {
            InitializeComponent();
        }
        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

    }
}
