using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_Parity
{
    class Program
    {
        public static int Parity(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum ^= num & 1;
                num = num >> 1;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            var sum = Program.Parity(23);
            Console.WriteLine(sum == 1 ? "Odd" : "Even");
        }
    }
}
