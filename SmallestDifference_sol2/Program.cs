using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDifference_sol2
{
    class Program
    {
        //Time Complexity O(nlogn) and space complexity O(1)
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length == 0 || arrayTwo.Length == 0) return null;
            if (arrayOne.Length == 1 || arrayTwo.Length == 1) return null;

            int arrayOneIdx = 0;
            int arrayTwoIdx = 0;

            int minDif = Int32.MaxValue;
            int[] pair = new int[2];

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);


            while (arrayOneIdx < arrayOne.Length && arrayTwoIdx < arrayTwo.Length)
            {
                int currentDif = Math.Abs(arrayOne[arrayOneIdx] - arrayTwo[arrayTwoIdx]);

                int previousDif = minDif;
                minDif = Math.Min(minDif, currentDif);

                if (previousDif > minDif)
                {
                    pair[0] = arrayOne[arrayOneIdx];
                    pair[1] = arrayTwo[arrayTwoIdx];

                }

                if (arrayOne[arrayOneIdx] < arrayTwo[arrayTwoIdx])
                {
                    arrayOneIdx++;
                }
                else if (arrayOne[arrayOneIdx] > arrayTwo[arrayTwoIdx])
                {
                    arrayTwoIdx++;
                }
                else if (arrayOne[arrayOneIdx] == arrayTwo[arrayTwoIdx])
                {
                    return pair;
                }

            }

            return pair;

        }


        static void Main(string[] args)
        {
            int[] arrayOne = new int[] {-1, 5, 10, 20, 28, 3};
            int[] arrayTwo = new int[] { 26, 134, 135, 15, 17 };

            int[] pair = Program.SmallestDifference(arrayOne, arrayTwo);

            foreach (var item in pair)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
