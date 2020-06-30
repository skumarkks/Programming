using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsets_new
{
    class Solution
    {
        public static List<List<int>> Subsets(List<int> array)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (int ele in array)
            {
                int length = subsets.Count;

                for (int i = 0; i < length; i++)
                {
                    List<int> currentSubset = new List<int>(subsets[i]);
                    currentSubset.Add(ele);
                    subsets.Add(currentSubset);
                }
            }

            return subsets;
        }

        static void Main(string[] args)
        {
            List<int> test1 = new List<int>(new int[] { 1, 2, 3 });
            List<List<int>> actual = Solution.Subsets(test1);

            foreach (var nums in actual)
            {
                foreach (var num in nums)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
