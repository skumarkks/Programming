using System;

namespace Fibinacci
{
    class Program
    {
        public int gcd(int num1, int num2)
        {
            if( num1==num2)
            {
                return num1;
            }
            else if(num1 > num2)
            {
                gcd(num1 - num2, num2);
            }
            else if( num2 > num1 )
            {
                gcd(num2 - num1, num1);
            }

        }

        public int Fibi(int n)
        {
            if (n <= 1) return 1;
           
            return Fibi(n - 1) + Fibi(n - 2);
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            //int n = 3;
            //int i = 0;
            //while (i <= n)
            //{
            //    var result = prg.Fibi(i);
            //    Console.WriteLine(result);
            //    i++;
            //}

            int result = prg.gcd(54, 36);
            Console.WriteLine(result);
        }
    }
}
