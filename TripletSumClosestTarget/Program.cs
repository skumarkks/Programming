using System;

namespace TripletSumClosestTarget
{
    class Program
    {
        public static int TripleSumClosestTarget(int[] num, int targetSum)
        {
            
            int minimumClose = Int32.MaxValue;

            for (int i = 0; i < num.Length-2; i++)
            {
                int left = i + 1; int right = num.Length - 1;
                while (left < right)
                {
                    int targetDiff = targetSum - num[i] - num[left] - num[right];

                    if (targetDiff == 0) return targetSum-targetDiff;

                    if (Math.Abs(targetDiff) < Math.Abs(minimumClose))
                        minimumClose = targetDiff;

                    if (targetDiff > 0)
                        left++;
                    else
                        right--;
                }
            }
            return targetSum- minimumClose;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
