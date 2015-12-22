using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_Simple
{
    class Program
    {
        static byte[] Buffer { get; set; }
        private static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //sck.Bind(new IPEndPoint(IPAddress.Any, 1234));
            sck.Bind(new IPEndPoint(0,1234));
            sck.Listen(100);

            //Blocking call, wait for unavailbe socket attempt to connect and transfer the availbale socket to accept
            Socket accepted = sck.Accept();
            //Default buffer size 8192, That is maximum no. of byte could receive at one time
            Buffer = new byte[accepted.SendBufferSize];
            //No. of byte read, Receiving data waiting in the buffer and transfer to Buffer
            int byteRead = accepted.Receive(Buffer);
            byte[] formated = new byte[byteRead];
            //To remove the Garbage bytes
            for (int i = 0; i < byteRead; i++)
            {
                formated[i] = Buffer[i];
            }
            string strData = Encoding.ASCII.GetString(formated);
            Console.WriteLine(strData);
            Console.Read();
            sck.Close();
        }
    }
}
