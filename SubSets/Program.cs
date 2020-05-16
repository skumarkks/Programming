using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSets
{
    class Program
    {
        public static List<List<int>> FindSubSets(int[] nums)
        {
            if (nums.Length == 0) return null;

            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (var num in nums)
            {
                int n = subsets.Count;

                for (int i = 0; i < n; i++)
                {
                    List<int> set = new List<int>(subsets.ElementAt(i));
                    set.Add(num);
                    subsets.Add(set);
                }

            }
            return subsets;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            var results = Program.FindSubSets(nums);

            foreach (var result in results)
            {
                foreach (var item in result)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();

            }


        }
    }
}
