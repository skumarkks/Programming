using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CombinationSum_39
{
    /*public class Solution
    {
        private List<List<int>> lists = (List<List<int>>)new ArrayList();
        private static int[] A;
        private static int[] R;
        private static int i = 0;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var lists = new ArrayList();

            Permutation(candidates, target, 0);
            return lists;
        }

        public  void Permutation(int[] candidates, int target, int k)
        {
            int sum = 0;
            if (sum > target)
            {
                i++;
            }
            else
            {
                while (k < candidates.Length)
                {
                    R[k] = candidates[i];
                    A[i] = 1;
                    if (sum == target)
                    {
                        lists.Add(new List<int>());
                        lists[lists.Count-1] = new List<int>();
                        var result = new List<int>();

                        for (int j = 0; j <= k; j++)
                        {
                            result.Add(R[j]);
                            result.Add(R[j]);
                            result.Add(R[j]);

                            lists[lists.Count - 1] = result;
                        }
                    }
                    Permutation(candidates, target,k+1);
                    A[i] = 0;
                }
            }
        }
    }*/


    public class Solution
    {
        public List<List<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();

            if (candidates == null || candidates.Length == 0)
            {
                return (List<List<int>>)result;
            }

            List<int> combinations = new List<int>();

            FindCombinationsToTarget(result, combinations, candidates, target, 0);

            return (List<List<int>>)result; 
        }

        private void FindCombinationsToTarget(IList<List<int>> result, 
                                                List<int> combinations, 
                                                int[] candidates, 
                                                int target, 
                                                int startIndex)
        {
            if (target == 0)
            {
                result.Add(new List<int>());
                result[result.Count-1].AddRange(combinations);
                return;
            }
            else
            {
                for (int i = startIndex; i < candidates.Length; i++)
                {
                    if (candidates[i] > target)
                    {
                        break;
                    }
                    
                    combinations.Add(candidates[i]);
                    FindCombinationsToTarget(result, combinations, candidates, target-candidates[i], i);
                    combinations.RemoveAt(combinations.Count - 1);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            int[] candidates = new int[] {2, 3, 6, 7};
            int target = 7;

 
            var result = sol.CombinationSum(candidates, target);
        }
    }
}
