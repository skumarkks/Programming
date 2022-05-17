using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum_1
{
    public class TripleSum
    {
        public static List<List<int>> FindTripleSum(int[] arr, int targetSum)
        {
            if (arr.Length == 0) return null;
            var result = new List<List<int>>();

            Array.Sort(arr);

            for (int i = 0; i < arr.Length-2; i++)
            {
                //Handling duplicates
                if (i+1 < arr.Length && arr[i] == arr[i + 1]) i++;
                SearchPair(arr, targetSum - arr[i], i + 1, result);
            }
            return result;
        }

        public static void SearchPair(int[] arr, int target, int left, List<List<int>> result)
        {
            int right = arr.Length - 1;

            while (left < right)
            {
                while (left < right&& arr[left] == arr[left + 1]) left++;
                while (left < right && arr[right] == arr[right - 1]) right--;

                int sum = arr[left] + arr[right];

                if (sum == target)
                {
                    result.Add(new List<int>() { -target, arr[left], arr[right] });
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] test1 = new int[] { -3, -2, 0, 1, 1, 2, 2, 3 };
            var expected = TripleSum.FindTripleSum(test1, 0);
            var results = new List<List<int>>() {
                        new List<int>(){-3,0,3},
                        new List<int>(){-3,1,2},
                        new List<int>(){-2,0,2}
                          };
            if(results == expected )
            {
                Console.WriteLine("passed");
                
            }
            

        }
    }

}
