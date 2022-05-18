using System;

namespace ProjectEuler_Multiples
{
    class Program
    {
        public int Multiples(int x, int y, int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
                


    static void Main(string[] args)
        {
            var prg = new Program();
            //int result = prg.Multiples(3, 5, 1000);
            int result = prg.Multiples(0, 0, 1000);
            Console.WriteLine(result);
        }
    }
}
