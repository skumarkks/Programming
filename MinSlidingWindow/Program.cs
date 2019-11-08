using System;

namespace MinSlidingWindow
{
    class Program
    {
        public int FindMinSlidingWindowOptimised(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;

            int minVal = Int32.MaxValue;

            int windowStart = 0;
            int windowEnd = 0;
            int sum = nums[windowStart];

            while(windowStart < nums.Length)
            {
                if(sum >= target)
                {
                    minVal = Math.Min(minVal, windowEnd - windowStart + 1);
                    sum = sum - nums[windowStart];
                    windowStart++;
                }
                else
                {
                    windowEnd++;
                    if (windowEnd < nums.Length)
                    {
                        sum = sum + nums[windowEnd];
                    }
                    else
                    {
                        windowEnd--;
                        break;
                    }
                    //minVal = (windowEnd - windowStart) + 1;
                }                
            }
            return minVal;
        }

        public int FindMinSlidingWindow(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            int minSpan = Int32.MaxValue;           

            for(int i = 0; i < nums.Length; i++)
            {
                int sum = 0; int Span = 0;
                for(int j = i; j < nums.Length; j++)
                {
                    Span++;
                    sum = sum + nums[j];
                    if (sum >= target)
                        minSpan = Math.Min(minSpan, Span);

                }
            }
            return minSpan;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            //int[] nums = {2,1,5,2,3,2 };
            int[] nums = { 2, 1, 5, 2, 8 };
            //int[] nums = { 3,4,1,1,6 };

            int result = prg.FindMinSlidingWindow(nums, 8);
            Console.WriteLine(result);

            result = prg.FindMinSlidingWindowOptimised(nums, 8);
            Console.WriteLine(result);
        }
    }
}
