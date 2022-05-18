using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSorted
{
    class Program
    {
        public bool isSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            //int[] array = new[] { -3, 2, 4, -5, 6, -8, -9, 10, -12, 3 };
            //int[] array = new[] { 3, 4, 6, 8, 9, 10, 12 };
            int[] array = new[] { 3, 4, 6, 8, 9, 10, 12,3};
            var prg = new Program();
            bool isSorted = prg.isSorted(array);
            Console.WriteLine(isSorted);
        }
    }
}
