using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDifference_1
{
    class Program
    {
        //Time Complexity O(nlogn) +O(mlogm) and space Complexity O(1)
        public static int[] FindSmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length == 0 || arrayTwo.Length == 0) return null;

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int arrayOneIdx = 0;
            int arrayTwoIdx = 0;

            int smallestDif = Int32.MaxValue;
            int[] smallestPair = new int[2];

            while (arrayOneIdx < arrayOne.Length && arrayTwoIdx < arrayTwo.Length)
            {
                int currentSmallestDif = 0;

                int firstNum = arrayOne[arrayOneIdx];
                int secondNum = arrayTwo[arrayTwoIdx];
                
                if (firstNum > secondNum)
                {
                    currentSmallestDif = firstNum - secondNum;
                    arrayTwoIdx++;
                }
                else if(firstNum < secondNum)
                {
                    currentSmallestDif = secondNum - firstNum;
                    arrayOneIdx++;
                }
                else if (firstNum == secondNum)
                {
                    return new int[]{firstNum, secondNum};
                }

                if (currentSmallestDif < smallestDif)
                {
                    smallestDif = currentSmallestDif;
                    smallestPair = new int[] {firstNum, secondNum};
                }
            }

            return smallestPair;
        }

        static void Main(string[] args)
        {
            int[] num1 = new int[] { -1, 5, 10, 20, 28, 3 };
            int[] num2 = new int[] {26, 134, 135, 15, 17};

            int[] result = Program.FindSmallestDifference(num1, num2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
