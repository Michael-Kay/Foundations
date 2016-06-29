using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            if (10 > 3)
            {
                Console.WriteLine("meow");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Woof");
                Console.Read();
            }
        }
    }
}
