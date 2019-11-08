using System;
using System.Collections.Generic;

namespace QuadrapuletSum
{
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
            int result = prg.SearchQuadrapulet(new int[] { 4, 1, 2, -1, 1, -3 }, 1, 4);
            Console.WriteLine(result);

            Console.WriteLine("Hello World!");
        }
    }
}
