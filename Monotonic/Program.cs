using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monotonic
{
    class Program
    {
        public static bool IsMonotonic(int[] array)
        {
            // Write your code here.
            bool IsNonIncreasing = true;
            bool IsNonDecreasing = true;

            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    IsNonIncreasing = false;
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    IsNonDecreasing = false;
                }
            }
            return IsNonIncreasing || IsNonDecreasing;
        }

        public static bool IsMonotonic_1(int[] array)
        {
            bool isIncreaseing = false;
            bool isDecreasing = false;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    isIncreaseing = true;
                }
                else
                {
                    isIncreaseing = false;
                    break;
                }

            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    isDecreasing = true;
                }
                else
                {
                    isDecreasing = false;
                    break;
                }

            }

            return isIncreaseing || isDecreasing;
        }

		static void Main(string[] args)
        {
            int[] test1 = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };

            bool result = Program.IsMonotonic_1(test1);
            Console.WriteLine(result);
        }
    }
}
