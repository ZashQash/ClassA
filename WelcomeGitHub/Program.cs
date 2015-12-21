using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 10;
            int b = 9;

            int c = a + b;

            read();
        }

        private static void read()
        {
            Console.WriteLine("Read Something");
            Console.ReadKey();
        }
    }
}
