using System;
using System.Collections.Generic;

namespace QuadrapuletSum
{
    public class Program1
    {
        //Time Complexity O(n^2) and Space complexity O(1)
        public static List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            if (array.Length == 0) return null;

            List<int[]> quadruplets = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i <= array.Length - 2; i++)
            {
                findpair(array, i, i + 1, targetSum - (array[i] + array[i + 1]), quadruplets);
            }

            return quadruplets;
        }

        public static void findpair(int[] array, int i, int j, int targetSum, List<int[]> quadruplets)
        {
            int left = j + 1;
            int right = array.Length - 1;

            while (left < right)
            {
                int sum = array[left] + array[right];
                if (sum == targetSum)
                {
                    int[] result = new int[] { array[i], array[j], array[left], array[right] };
                    quadruplets.Add(result);
                    left++;
                    right--;
                }
                else if (sum < targetSum)
                {
                    left++;
                }
                else if (sum > targetSum)
                {
                    right--;
                }
            }
        }
    }


    class Program
    {
        public int SearchQuadrapulet(int[] num, int targetSum, int k)
        {
            Array.Sort(num);
            var quadrapulet = new List<List<int>>();

            for (int i = 0; i < num.Length-3; i++)
            {
                if (i > 0 && num[i] == num[i - 1])
                    continue;
                for (int j = i+1; j < num.Length - 2; j++)
                {
                    if (j > i+1 && num[j] == num[j - 1])
                        continue;
                    SearchPair(num, targetSum - (num[i] + num[j]), i, j, quadrapulet);
                }
            }
            return quadrapulet.Count;
        }

        private void SearchPair(int[] num, int targetSum, int Currentleft, int LeftButOne, List<List<int>> quadrapulet)
        {
            int left = LeftButOne + 1;
            int right = num.Length - 1;

            while(left < right)
            {
                int targetDiff = targetSum - num[left];

                if(targetDiff == num[right])
                {
                    quadrapulet.Add(new List<int>() { num[Currentleft], num[LeftButOne], num[left], num[right] });
                    left++;
                    right--;

                    while(left < right && num[left] == num[left-1])
                    {
                        left++;
                    }

                    while(left< right && num[right]==num[right+1])
                    {
                        right--;
                    }
                }
                else if(targetDiff > num[right])
                {
                    right--;

                }
                else
                {
                    left++;
                }
            }
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            var result = Program1.FourNumberSum(new int[] {7, 6, 4, -1, 1, 2}, 16);



            //int result = prg.SearchQuadrapulet(new int[] { 4, 1, 2, -1, 1, -3 }, 1, 4);
            Console.WriteLine(result);

            Console.WriteLine("Hello World!");
        }
    }
}
