using System;
using System;
using System.Collections.Generic;

namespace FindTripletSum
{
    public class Program
    {
        //TimeComplexity O(nLogn) + O(n2) ~ O(n2)
        //Space Complexity O(1)

        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.

            if (array.Length == 0) return null;
            if (array.Length < 3) return null;

            List<int[]> result = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                int pairSum = targetSum - array[i];
                FindPairAndFormTriplet(array, i, pairSum, result);
            }

            return result;
        }

        public static void FindPairAndFormTriplet(int[] array, int i, int pairSum, List<int[]> result)
        {
            int left = i + 1;
            int right = array.Length - 1;

            while (left < right)
            {
                int currentSum = array[left] + array[right];

                if (currentSum == pairSum)
                {
                    int[] triplet = new int[] { array[i], array[left], array[right] };
                    result.Add(triplet);
                    right--;
                    left++;
                }
                else if (currentSum < pairSum)
                {
                    left++;
                }
                else if (currentSum > pairSum)
                {
                    right--;
                }
            }

        }

        public static void Main(string[] args)
        {
            int[] num = new int[]{ 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;

            List<int[]> result = Program.ThreeNumberSum(num, targetSum);

            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.Write("{0} ", i);
                }

                Console.WriteLine();
            }
        }
    }

}
