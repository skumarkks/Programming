using System;
using System.Collections.Generic;

namespace SubArrayWithSum
{
    class Program
    {
        void FindSubArrayWithZeroSumHashMap(int[] nums, int target)
        {
            if (nums.Length == 0) return;

            var sumMap = new Dictionary<int, int>();
            sumMap.Add(0, -1);
            
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sumMap.ContainsKey(sum))
                {
                    int k = sumMap[sum];
                    Console.Write("{");

                    for (int j = k + 1; j <= i; j++)
                    {
                        Console.Write("{0},", nums[j]);
                    }
                    Console.WriteLine("}");
                }
                else
                {
                    sumMap.Add(sum, i);
                }

            }

        }


        void FindSubArrayWithZeroSum(int[] nums, int target)
        {
            if (nums.Length == 0) return;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if(sum == target)
                    {
                        Console.Write("{");
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write("{0},", nums[k]);
                        }
                        Console.WriteLine("}");
                    }


                }
            }
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            prg.FindSubArrayWithZeroSum(new int[] {3,4,-7,3,1,3,1,-4,-2,-2 }, 0);
            Console.WriteLine("Hello World!");
            prg.FindSubArrayWithZeroSumHashMap(new int[] { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 }, 0);
            
        }
    }
}
