using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_PascalTriangle
{
    class Program
    {
        public static void PascalTriangle(long layer)
        {
            long number = 1;
            if (layer == 1)
            {
                Console.WriteLine(number);
                return;
            }
            else
            {
                Console.WriteLine(number);
                for (long i = 0; i < layer; i++)
                {
                    number = (number * (layer - i)) / (i + 1);
                    if(number == 0)
                        Console.WriteLine(1);
                    Console.WriteLine(number);
                }
            }

        }
        static void Main(string[] args)
        {
            PascalTriangle(5);
        }
    }
}
