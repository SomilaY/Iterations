using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========");
            Console.ReadLine();
            Print(7);

          
            
        }

        static void Print(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine("Hello World");
                Print(x + 1);
            }
        }
    }
}
