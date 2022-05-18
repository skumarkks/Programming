using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositveNegativeNumbers
{
    class Program
    {
        public void PositiveNegativeNumber(int[] array)
        {
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                while (array[i] < 0) i++;
                while (array[j] >= 0) j--;
                if (i < j)
                    swap(array, i, j);
            }
        }

        private void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = new[] {-3, 2, 4, -5, 6, -8, -9, 10, -12, 3};
            var prg = new Program();
            prg.PositiveNegativeNumber(array);
            foreach (var i in array)
            {
                Console.WriteLine(i);

            }
        }
    }
}
