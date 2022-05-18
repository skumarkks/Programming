using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CombinationSum2_40
{
    public class Solution
    {
        public List<List<int>> CombinationSum2(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            if (candidates == null || candidates.Length == 0)
            {
                return result;
            }

            Array.Sort(candidates);

            List<int> combination = new List<int>();

            FindCombinationSum2ToTarget(result, combination, candidates, target, 0);
            return result;
        }

        private void FindCombinationSum2ToTarget(List<List<int>> result, List<int> combination, int[] candidates, int target, int startIndex)
        {
            if (target == 0)
            {
                result.Add(new List<int>());
                result[result.Count - 1].AddRange(combination);
                return;
            }

            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    break;
                }

                combination.Add(candidates[i]);
                FindCombinationSum2ToTarget(result, combination,candidates, target- candidates[i], i+1);
                combination.RemoveAt(combination.Count-1);
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            //int[] candidates = new int[] { 2, 5, 2, 1, 2 };
            //int target = 5;

            int[] candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;


            var result = sol.CombinationSum2(candidates, target);
        }
    }
}
