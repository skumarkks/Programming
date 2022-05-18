using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_ShuffleArray
{
    public class Solution
    {
        private int[] numArray;
        private int[] numResult;
        private List<int> numList = new List<int>();
        public Solution(int[] nums)
        {
            numArray = nums;
            numResult = new int[nums.Length];

            foreach (int i in nums)
            {
                numList.Add(i);
            }
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            List<int> listtemp = new List<int>();
            foreach (int i in numArray)
            {
                listtemp.Add(i);
            }

            numList = listtemp;
            return numArray;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            int[] nums = numArray;
            var random = new Random();
            
            for (int i = 0; i < numArray.Length; i++)
            {
                int a = random.Next(0, numList.Count-1);
                numResult[i] = numList.ElementAt(a);
                numList.RemoveAt(a);
            }
            return numResult;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            var nums = new int[] {1,2,3};
            for (int i = 0; i < nums.Length; i++)
            {
                Solution obj = new Solution(nums);

                int[] param1 = obj.Reset();
                int[] param2 = obj.Shuffle();
                foreach (var p in param2)
                {
                    Console.Write(p);
                }
                Console.WriteLine();
            }
        }
    }
}
