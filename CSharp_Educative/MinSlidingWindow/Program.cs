using System;

namespace MinSlidingWindow
{
    public class SubArray
    {
        public struct Result
        {
            public int start;
            public int end;
            public int Sum;
        }

        public Result FindSmallestSubArraySum(int[] nums, int s)
        {
            var result = new Result();
            result.start = -1;
            result.end = -1;
            result.Sum = 0;
            if (nums.Length == 0) return result;

            int start = 0;
            int end = 0;
            int minLength = Int32.MaxValue;
            int sum = 0;

            while (end < nums.Length)
            {
                sum += nums[end];

                while (sum >= s)
                {
                    int currentLength = minLength;
                    minLength = Math.Min(minLength, end - start + 1);
                    if (currentLength != minLength)
                    {
                        result.start = start;
                        result.end = end;
                        result.Sum = sum;
                    }
                    sum -= nums[start];
                    start++;
                }
                end++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var test = new SubArray();
            var nums = new int[] { 2, 1, 5, 2,3,2 };
            var result = test.FindSmallestSubArraySum(nums, 7);
            var expectedLength = 2;
            var expectedSum = 7;

            if ((result.end - result.start + 1 == expectedLength) && result.Sum == expectedSum)
            {
                for (int i = result.start; i <= result.end; i++)
                {
                    Console.Write("{0}", nums[i]);
                }
            }
            Console.WriteLine();

            nums = new int[] { 2, 1, 5, 2,8 };
            result = test.FindSmallestSubArraySum(nums, 7);
            expectedLength = 1;
            expectedSum = 8;

            if ((result.end - result.start + 1 == expectedLength) && result.Sum == expectedSum)
            {
                for (int i = result.start; i <= result.end; i++)
                {
                    Console.Write("{0}", nums[i]);
                }
            }

            Console.WriteLine();

            nums = new int[] { 3,4,1,1,6 };
            result = test.FindSmallestSubArraySum(nums, 8);
            expectedLength = 3;
            expectedSum = 8;

            if ((result.end - result.start + 1 == expectedLength) && result.Sum == expectedSum)
            {
                for (int i = result.start; i <= result.end; i++)
                {
                    Console.Write("{0}", nums[i]);
                }
            }
        }
    }

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

        /*static void Main(string[] args)
        {
            var prg = new Program();
            //int[] nums = {2,1,5,2,3,2 };
            int[] nums = { 2, 1, 5, 2, 8 };
            //int[] nums = { 3,4,1,1,6 };

            int result = prg.FindMinSlidingWindow(nums, 8);
            Console.WriteLine(result);

            result = prg.FindMinSlidingWindowOptimised(nums, 8);
            Console.WriteLine(result);
        }*/
    }
}
