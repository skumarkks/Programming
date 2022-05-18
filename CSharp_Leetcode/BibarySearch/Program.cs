using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibarySearch
{
    class Program
    {
        public int BinarySearch(int[] array, int l, int h, int key)
        {
            int mid = (l + h) / 2;

            if (l > h)
                return -1;

            if (key == array[mid])
                return mid;

            if (key < array[mid])
            {
                return BinarySearch(array, l, mid - 1, key);
            }
            else
            {
                return BinarySearch(array, mid + 1, h, key);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new[] {2, 3, 4, 5, 6, 10, 11};
            var prg = new Program();
            int index = prg.BinarySearch(array, 0, array.Length - 1, 9);
            Console.WriteLine(index);
        }
    }
}
