using System;

namespace Diff
{
    class Program
    {
        public void Diff(int[] nums)
        {
            int max = nums[nums.Length-1];
            int diff = nums[nums.Length - 1];
            int minValue = Int32.MaxValue;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] > max)
                    max = nums[i];
                else
                {
                    int currentDiff = Math.Min(diff, max - nums[i]);
                    if(currentDiff != diff)
                    {
                        minValue  = nums[i];
                        diff = currentDiff;
                    }
                }
            }

            Console.WriteLine("{0 } {1}",  max, minValue);
}

        static void Main(string[] args)
        {
            var prg = new Program();
            prg.Diff(new int[] { 2, 7, 9, 5, 1, 3, 5 });
            Console.WriteLine("Hello World!");
        }
    }
}
