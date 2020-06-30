using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumberSum
{
    class Program
    {
        //TimeComplexity O(n) and Space complexity O(n)
        public static int[] FindTwoNumberSum_sol1(int[] num, int sum)
        {
            if (num.Length == 0) return null;
            if (num.Length == 1) return null;

            HashSet<int> hashMap = new HashSet<int>();

            for (int i = 0; i < num.Length; i++)
            {
                int dif = sum - num[i];

                if (hashMap.Contains(dif))
                {
                    return new[] {num[i], dif};
                }
                else
                {
                    hashMap.Add(num[i]);
                }
            }

            return null;
        }

        // Timne Complexity O(nlogn) and SpaceComplexity O(1)
        public static int[] FindTwoNumberSum_sol2(int[] num, int sum)
        {
            if (num.Length == 0) return null;
            if (num.Length == 1) return null;

            Array.Sort(num);

            int leftIdx = 0;
            int rightIdx = num.Length-1;

            while (leftIdx < rightIdx)
            {
                int currentSum = num[leftIdx] + num[rightIdx];

                if (currentSum < sum)
                {
                    leftIdx++;
                }
                else if (currentSum > sum)
                {
                    rightIdx--;
                }
                else if (currentSum == sum)
                {
                    return new int[] {num[leftIdx], num[rightIdx]};
                }

            }

            return null;
        }


        static void Main(string[] args)
        {
            {
                int[] num = new int[] {2, 8, 10, 11, 15, 15};
                int sum = 30;

                int[] result = Program.FindTwoNumberSum_sol1(num, sum);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                num = new int[] {2, 8, 10, 11, 15, 15};
                sum = 26;

                result = Program.FindTwoNumberSum_sol1(num, sum);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            {
                Console.WriteLine("Method2");
                int[] num = new int[] { 2, 8, 10, 11, 15, 15 };
                int sum = 30;

                int[] result = Program.FindTwoNumberSum_sol2(num, sum);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                num = new int[] { 2, 8, 10, 11, 15, 15 };
                sum = 26;

                result = Program.FindTwoNumberSum_sol2(num, sum);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
