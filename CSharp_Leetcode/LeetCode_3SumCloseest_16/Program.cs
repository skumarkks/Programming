using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_3SumCloseest_16
{
    class Program
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int previsousSum = nums[0] + nums[1] + nums[2];
            if (previsousSum == target)
            {
                
                return previsousSum;
            }
            else if (previsousSum > target)
            {
                return previsousSum;
            }

            for (int i = 1; i < nums.Length-2; i++)
            {
                int currentSum = nums[i] + nums[i+1] + nums[i+2];
                if (i + 2 < nums.Length && i + 3 < nums.Length)
                {
                    int currentSum1 = nums[i] + nums[i + 2] + nums[i + 3];


                    if ((target - currentSum1) < (target - currentSum))
                    {
                        currentSum = currentSum1;
                    }
                }

                if ((previsousSum <= target) && ( target <= currentSum))
                {
                    if (Math.Abs(target-previsousSum) <= Math.Abs(currentSum-target))
                    {
                       // int outResult = findNumberClosest(nums[i-1], nums[i], nums[i+1], target);
                       // return outResult;
                        return previsousSum;
                    }
                    else
                    {
                        //int outResult = findNumberClosest(nums[i], nums[i + 1], nums[i + 2], target);
                        //return outResult;
                        return currentSum;
                    }
                }
                else
                {
                    previsousSum = currentSum;
                }
            }
            return previsousSum;
        }

        public  static int findNumberClosest(int i, int i1, int i2, int target)
        {
            int x = Math.Abs(target - i);
            int y = Math.Abs(target - i1);
            int z = Math.Abs(target - i2);

            if (x != 0 && y != 0 && z != 0)
            {
                int m = Math.Min(Math.Min(x, y), z);
                if (m == x)
                    return i;
                else if (m == y)
                    return i1;
                else if (m == z)
                    return i2;
            }
            else if( x==0)
            {
                if (y < z)
                    return i1;
                else
                {
                    return i2;
                }
            }
            else if (y == 0)
            {
                if (x < z)
                    return i;
                else
                {
                    return i2;
                }
            }
            else if (z == 0)
            {
                if (x < y)
                {
                    return i;
                }
                else
                {
                    return i1;
                }
            }
            return 0;
        }

        /*public  static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int min = Int32.MaxValue;
            int res = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                int l = 0, r = i - 1;

                while (l < r)
                {
                    int sum = nums[l] + nums[r] + nums[i];
                    if (sum == target)
                    {
                        return target;
                    }
                    int diff = Math.Abs(target - sum);
                    if (diff < min)
                    {
                        min = diff;
                        res = sum;
                    }
                    if (sum < target)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }
            return res;
        }*/


        static void Main(string[] args)
        {
            int[] nums = new[] {0,2,1,-3 };
            int result = ThreeSumClosest(nums, 1);
            Console.WriteLine(result);
        }
    }
}
