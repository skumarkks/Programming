using System;
using System.Collections.Generic;

namespace PermutationWithConstrains
{
    class Program
    {
        public void PermutationWithConstrains(int[] nums,int l, int h, int k,
                                               List<int> perm, List<IList<int>> perms)
        {
            if(k == 0)
            {
                List<int> temp = new List<int>(perm);
                perms.Add(temp);
                return;
            }

            for (int i = l; i < h; i++)
            {
                while (i < h - 1 && nums[i] == nums[i + 1])
                    i++;
                perm.Add(nums[i]);
                PermutationWithConstrains(nums, l + 1, h, k-1, perm, perms);
                perm.Remove(nums[i]);
                while (i < h - 1 && nums[i] == nums[i + 1])
                    i++;
                if (perm.Count == 0)
                {
                    l++;
                    while (i < h - 1 && nums[i] == nums[i + 1])
                    {
                        l++;                        
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            var test = new Program();
            var nums = new int[] { 1, 1, 3,4 };
            var perm = new List<int>();
            var perms = new List<IList<int>>();
            test.PermutationWithConstrains(nums, 0, nums.Length, 2, perm, perms);

            foreach (var item in perms)
            {
                foreach (var i in item)
                {
                    Console.Write("{0} ",i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
