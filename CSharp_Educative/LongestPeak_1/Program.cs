using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPeak_1
{
    class Program
    {
        public static int[] FindLongestPeek(int[] array)
        {
            if (array == null) return null;

            int i = 1;
            int maxPeekLength = Int32.MinValue;
            int[] maxPeekDimension = new int[2] {-1, -1};

            while (i < array.Length-1)
            {
                if ((array[i - 1] < array[i]) &&
                    (array[i] > array[i+1]))
                {
                    int leftIdx = i - 2;
                    int rightIdx = i + 2;

                    while (leftIdx >= 0 && (array[leftIdx + 1] > array[leftIdx])) leftIdx--;
                    while (rightIdx < array.Length && (array[rightIdx - 1] > array[rightIdx])) rightIdx++;

                    int peekLength = rightIdx - leftIdx - 1;

                    if (maxPeekLength < peekLength)
                    {
                        maxPeekLength = peekLength;
                        maxPeekDimension[0] = array[leftIdx + 1];
                        maxPeekDimension[1] = array[rightIdx - 1];

                    }

                    i = rightIdx;
                }
                else
                {
                    i++;
                }    
            }

            return maxPeekDimension[0] != -1 ? maxPeekDimension : null;

        }

        static void Main(string[] args)
        {
            int[] num = new int[] {1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3};
            var results = Program.FindLongestPeek(num);

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
            
        }
    }
}
