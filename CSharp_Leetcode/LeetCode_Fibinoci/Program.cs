using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Fibinoci
{
    class Program
    {
        public static int fibinoci(int n)
        {
            //if (n == 0)
            //{
            //    Console.WriteLine(0);
            //    return 0;
            //}

            //if (n == 1)
            //{
            //    Console.WriteLine(1);
            //    return 1;
            //}
            if (n < 2)
            {
                Console.WriteLine(n);
                return n;
            }

            if (n >= 2)
            {
                int x = fibinoci(n - 1) + fibinoci(n - 2);
                Console.WriteLine(x);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Program.fibinoci(2);

        }
    }
}
