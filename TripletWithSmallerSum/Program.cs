using System;

namespace TripletWithSmallerSum
{
    class Program
    {
        public static int TripletWithSmallerSum(int[] num, int target)
        {
            int minCount = 0;
            Array.Sort(num);
            

            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Program.TripletWithSmallerSum(new int[] { -1, 0, 2, 3 }, 3));
            Console.WriteLine(Program.TripletWithSmallerSum(new int[] { -1, 4, 2, 1, 3 }, 5));
            Console.WriteLine("Hello World!");
        }
    }
}
