using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LongestPalindromicSubString;

namespace LongestPalindromicSubString
{
    class Solution
    {
        public static string LongestPalindromicSubstring(string str)
        {
            int[] currentLongest = {0, 1};

            for (int i = 1; i < str.Length; i++)
            {
                int[] odd = GetLongestPalindromeFrom(str, i - 1, i + 1);
                int[] even = GetLongestPalindromeFrom(str, i - 1, i);
                int[] longest = odd[1] - odd[0] > even[1] - even[0] ? odd : even;

                currentLongest = currentLongest[1] - currentLongest[0] > longest[1] - longest[0]
                    ? currentLongest
                    : longest;
            }

            return str.Substring(currentLongest[0], currentLongest[1] - currentLongest[0]);
        }

        public static int[] GetLongestPalindromeFrom(string str, int leftIdx, int rightIdx)
        {
            while (leftIdx >= 0 && rightIdx < str.Length)
            {
                if (str[leftIdx] != str[rightIdx])
                    break;
                leftIdx--;
                rightIdx++;
            }

            return new int[] {leftIdx + 1, rightIdx};
        }
    }


    class Program
    {
        public static string LongestPalindromicSubString(string str)
        {
            int currentsubstringLength = Int32.MinValue;
            string palindromicSubstring = null;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    string substring = str.Substring(i, j + 1 - i);

                    if (substring.Length > currentsubstringLength && IsPalindrome(substring))
                    {
                        currentsubstringLength = substring.Length;
                        palindromicSubstring = substring;
                    }
                }

            }

            return palindromicSubstring;
        }

        private static bool IsPalindrome(string substring)
        {
            int leftIdx = 0;
            int rightIdx = substring.Length - 1;

            while (leftIdx < rightIdx)
            {
                if (substring[leftIdx] != substring[rightIdx])
                    return false;
                leftIdx++;
                rightIdx--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            //string str = "abaxyzzyxb";
            string str = "aba";
            string palindromicSubstring = Program.LongestPalindromicSubString(str);
            Console.WriteLine(palindromicSubstring);
            palindromicSubstring = Solution.LongestPalindromicSubstring(str);
            Console.WriteLine(palindromicSubstring);
        }
    }
}

