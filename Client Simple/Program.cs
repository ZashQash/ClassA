using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client_Simple
{
    class Program
    {
        private static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint locaEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);

            try
            {
                sck.Connect(locaEndPoint);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to connect remote end point");
                Main(args);
            }

            Console.WriteLine("Enter Text: ");
            string text = Console.ReadLine();
            byte[] data = Encoding.Default.GetBytes(text);

            sck.Send(data);
            Console.WriteLine("Data Sent!");
            Console.WriteLine("Press Any key Continue");
            Console.Read();
            sck.Close();
        }
    }
}
