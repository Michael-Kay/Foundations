using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
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
            int answer = 1; 

            int i = 1;
            while (i < n)
            {
                if (i == 1)
                {
                    answer = 1;
                    i++;
                }
                else 
                {
                    answer = i * answer;
                    i++;
                }
              
            }

            Console.WriteLine(n + "!   =   " + answer);
            Consle.ReadLine();
        }
    }
}


*/

/*
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

        int[] product = new int [1];

        int i = 1;


        if (n == 0)
        {
            Console.WriteLine("0!   ==  1");
        }
        else
        {

            while (i <= n)
            {
                product = product * n;

                if (product > n)
                {
                    break;
                }
                if (product < n)
                {
                    continue;
                }
                i++;
                return [product];
            }

            Console.WriteLine(n + "!   =   " + product);
            Console.ReadLine();
        }
    }
}
}
*/

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

            int factorial = 1;
            int i;
            for (int i = 1; i <= n; i++)
            {
                factorial *= 1;
                Console.WriteLine(factorial);
            }
            
            Console.ReadLine();
        }
    }
}
