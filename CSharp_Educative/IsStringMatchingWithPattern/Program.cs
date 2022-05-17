/*
 * This is the wildcard matching problem: Leet code 044
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringMatchingWithPattern
{
    class Program
    {
        public bool IsMatch(string s, string p)
        {
            char[] str = s.ToCharArray();
            char[] pattern = p.ToCharArray();

            //a***b ==> a*b
            int writeIndex = 0;
            bool isFirst = true;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '*')
                {
                    if (isFirst)
                    {
                        pattern[writeIndex++] = pattern[i];
                        isFirst = false;
                    }
                }
                else
                {
                    pattern[writeIndex++] = pattern[i];
                    isFirst = true;
                }
            }

            int[,] A = new int[str.Length + 1, writeIndex + 1];

            if (pattern[0] == '*')
            {
                A[0, 1] = 1;
            }

            A[0, 0] = 1;


            for (int i = 1; i < A.GetLength(0); i++)
            {
                for (int j = 1; j < A.GetLength(1); j++)
                {
                    if (str[i - 1] == pattern[j - 1] || pattern[j - 1] == '?')
                    {
                        A[i, j] = A[i - 1, j - 1];
                    }
                    else if (pattern[j - 1] == '*')
                    {
                        if (A[i - 1, j] == 1)
                            A[i, j] = 1;
                        else if (A[i, j - 1] == 1)
                            A[i, j] = 1;
                    }
                    else
                        A[i, j] = 0;
                }
            }

            return A[str.Length, writeIndex] == 1 ? true : false;
        }

        static void Main(string[] args)
        {
            string s = "xaylmz";
            string p = "x?y*z";

            var sol = new Program();
            bool isMatch = sol.IsMatch(s, p);

        }
    }
}
