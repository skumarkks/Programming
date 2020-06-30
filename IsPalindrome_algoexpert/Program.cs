using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome_algoexpert
{
    class Solution
    {
        public static bool IsPalindrome(string str)
        {
            if (str.Length < 2) return false;

            int left = 0;
            int right = str.Length - 1;

            char[] charString = str.ToCharArray();

            while (left < right)
            {
                if (charString[left] != charString[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {

            string test1 = "abccba";
            bool isResult = Solution.IsPalindrome(test1);
            Console.WriteLine(isResult ? "Pass" : "Fail");


            string test2 = "abcdcba";
            isResult = Solution.IsPalindrome(test2);
            Console.WriteLine(isResult ? "Pass" : "Fail");

            string test3 = "ab";
            isResult = Solution.IsPalindrome(test3);
            Console.WriteLine(isResult ? "Pass" : "Fail");


            string test4 = "aba";
            isResult = Solution.IsPalindrome(test4);
            Console.WriteLine(isResult ? "Pass" : "Fail");

            string test5 = "abb";
            isResult = Solution.IsPalindrome(test5);
            Console.WriteLine(isResult ? "Pass" : "Fail");

            string test6 = "abcbc";
            isResult = Solution.IsPalindrome(test6);
            Console.WriteLine(isResult ? "Pass" : "Fail");

            string test7 = "";
            isResult = Solution.IsPalindrome(test7);
            Console.WriteLine(isResult ? "Pass" : "Fail");

        }
    }
}
