using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string a)
        {
            string s = a.ToLower();

            for (int i = 0, j = s.Length - 1;
                i < s.Length && j > 0;
                i++, j--)
            {
                if (s[i] != s[j])
                    return false;

            }
            return true;
        }

        static void Main(string[] args)
        {
            bool bResult = IsPalindrome("Nitin");
        }
    }
}
