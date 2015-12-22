using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client_Medium
{
    class Program
    {

        private static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994);
            sck.Connect(endPoint);

            Console.Write("Enter Message: ");
            string msg = Console.ReadLine();
            byte[] msgBuffer = Encoding.Default.GetBytes(msg);
            sck.Send(msgBuffer, 0, msgBuffer.Length, 0);

            byte[] buffer = new byte[255];
            int byteRead = sck.Receive(buffer);

            Array.Resize(ref buffer, buffer.Length);
            Console.WriteLine("Receive: {0}", Encoding.Default.GetString(buffer));
            
            Console.Read();
            sck.Close();
        }
    }
}
