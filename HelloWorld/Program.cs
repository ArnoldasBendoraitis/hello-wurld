using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Program requires at least one argument");
            }
            Console.WriteLine(string.Format("Hello {0}!", args[0]));
            Console.ReadLine();
        }
    }
}
