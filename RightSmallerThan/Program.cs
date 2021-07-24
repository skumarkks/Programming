using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightSmallerThan
{
    class Program
    {
        //Time complexity O(n^2) and space complexity O(n)
        public static int[] RightSmallerThan(int[] num)
        {
            int[] rightSmaller = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                int count = 0;
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i] > num[j]) count++;
                }

                rightSmaller[i] = count;
            }

            return rightSmaller;
        }

        static void Main(string[] args)
        {
            int[] num = new int[] {8, 5, 11, -1, 3, 4, 2};
            int[] result = RightSmallerThan(num);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
