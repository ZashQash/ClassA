using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_Medium
{
    class Program
    {
        private static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any,1994);
            sck.Bind(localEndPoint);
            sck.Listen(0);

            Socket accept = sck.Accept();
            byte[] buffer = Encoding.Default.GetBytes("Hello Client!");
            accept.Send(buffer);

            buffer = new byte[255];
            int byteRead = accept.Receive(buffer);
            Array.Resize(ref buffer, byteRead);

            Console.WriteLine("Recived: {0}", arg0: Encoding.Default.GetString(buffer));
            Console.Read();
            
            sck.Close();
            accept.Close();

        }
    }
}
