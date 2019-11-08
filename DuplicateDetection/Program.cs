using System;
using System.Collections.Generic;

namespace DuplicateDetection
{
    class Program
    {
        public void FindDuplicate(int[] nums)
        {
            var charFrequencyMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(charFrequencyMap.ContainsKey(nums[i]))
                {
                    charFrequencyMap[nums[i]] += 1;
                }
                else
                {
                    charFrequencyMap.Add(nums[i], 1);
                }
            }
            foreach(var i in charFrequencyMap)
            {
                if(i.Value > 1)
                {
                    Console.Write("{0} ", i.Key);
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            prg.FindDuplicate(new int[] {1,2,5,3,4,4,5 });

            //Console.WriteLine(result);
        }
    }
}
