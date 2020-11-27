using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_1
{
    class Program
    {

        public static void Permutation(int[] num, int low, int high, List<List<int>> permutations)
        {
            if (low == high)
            {
                permutations.Add(new List<int>(num));
                return;
            }

            for (int i = low; i <= high; i++)
            {
                swap(num, i, low);
                Permutation(num, low + 1, high, permutations);
                swap(num, i, low);
            }
        }

        public static void swap(int[] num, int i, int j)
        {
            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }

        public static List<List<int>> Permutation(int[] num)
        {
            if (num.Length == 0) return null;

            List<List<int>> permutations = new List<List<int>>();
            Permutation(num, 0, num.Length - 1, permutations);
            return permutations;
        }


        static void Main(string[] args)
        {
            int[] num = new int[]{1,2,3};

            List<List<int>> results = Permutation(num);

            foreach (var result in results)
            {
                foreach (var i in result)
                {
                    Console.Write("{0} ", i);
                }

                Console.WriteLine();
            }

        }
    }
}
