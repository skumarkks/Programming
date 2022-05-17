using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    public class ContainerWithMostWater
    {
        // TimeComplexity O(n) and space complexity O(1)
        public static int FindMaxAreaofMostWaterInContainer(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1) return 0;

            int left = 0;
            int right = arr.Length - 1;

            int maxArea = Int32.MinValue;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(arr[left], arr[right]) * (right - left));
                if (arr[left] <= arr[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        public static void Main(string[] args)
        {
            int[] test1 = new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            int maxAreaExpected = ContainerWithMostWater.FindMaxAreaofMostWaterInContainer(test1);
            int maxAreaActual = 49;

            Console.WriteLine(maxAreaExpected == maxAreaActual ? "PASS" : "FAIL");
        }

    }
}
