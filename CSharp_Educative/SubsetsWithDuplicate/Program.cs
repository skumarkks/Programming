using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetsWithDuplicate
{
    public class Program
    {
        public static List<List<int>> FindSubSets(int[] nums)
        {
            if (nums.Length == 0) return null;

            List<List<int>> subSets = new List<List<int>>();
            subSets.Add(new List<int>());

            Array.Sort(nums);


            int endIdx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int startIdx = 0;

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    startIdx = endIdx + 1;
                }
                
                endIdx = subSets.Count-1;

                for (int j = startIdx; j <= endIdx; j++)
                {
                    List<int> set = new List<int>(subSets.ElementAt(j));
                    set.Add(nums[i]);
                    subSets.Add(set);
                }
            }
            return subSets;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 3, 3, 4};
            List<List<int>> results = Program.FindSubSets(nums);

            foreach (var result in results)
            {
                foreach(var i in result)
                    Console.Write("{0} ", i);
                Console.WriteLine();
            }
        }
    }
}
