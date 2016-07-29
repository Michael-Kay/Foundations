using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of factorials to display...\n");
            String input = Console.ReadLine();

            int n;
            bool isNumeric = int.TryParse(input, out n);

            int x = 1;
 
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            Console.WriteLine(n + "!   =   " + x);
            Console.ReadLine();
        }
    }
}


