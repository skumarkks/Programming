using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_ArrayPermutation
{
    class Program
    {
        public void Permutation(char[] a, int i)
        {
            if (i == a.Length-1)
            {
                PrintArray(a);
                Console.WriteLine();
                return;
            }
            
            for (int j = i; j < a.Length; j++)
            {
                swap(a, i, j);
                Permutation(a, i + 1);
                swap(a, i, j);
            }
        }

        private void swap(char[] c, int i, int j)
        {
            char ch = c[i];
            c[i] = c[j];
            c[j] = ch;
        }


        private void PrintArray(char[] ints)
        {
            foreach (char a in ints)
                Console.Write(a);
        }

        static void Main(string[] args)
        {
            var p = new Program();
            char[] str = new char[] {'1', '0', '2','9','2'};
            p.Permutation(str, 0);

        }
    }
}
