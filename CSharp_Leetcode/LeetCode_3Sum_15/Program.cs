using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_3Sum_15
{
    public class Solution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            var lists = new List<List<int>>();

            //if the nums count is less than 3
            if (nums.Length <= 2)
            {
                return null;
            }

            int target = 0;
            var dictionary = new Dictionary<int, int>();
            // go through the list
            for (int i = 0; i < nums.Length-1; i++)
            {
                // get the thrid nummber
                int diff = target - (nums[i] + nums[i + 1]);

                // is the diff contains in the dictionary. other number is the list
                if (dictionary.ContainsKey(diff))
                {
                    
                    var result = new List<int> ();
                    result.Add(nums[i]);
                    result.Add(nums[i+1]);
                    result.Add(diff);

                    // is this list already exist then skip and if the index is -1 the group exist.
                    if (lists.IndexOf(result) == -1)
                    {
                        // check add to the list
                        int listLength = lists.Count;
                        lists.Add(new List<int>());
                        lists[listLength] = new List<int>();
                        lists[listLength] = result;
                    }
                }
                else
                {
                    if (!dictionary.ContainsKey(nums[i]))
                        dictionary.Add(nums[i], i);
                }
            }

            return lists;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            //var nums = new int[]{-1, 0, 1, 2, -1, -4};
            //var nums = new int[] {-1, 0,1};

            var nums = new int[] { 1, 0, -1, 0, -2, 2 };

            sol.ThreeSum(nums);
        }
    }
}
