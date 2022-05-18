using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10_LeetCode_RegularexpressionMatching
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
                return false;

            bool firstMatch = !string.IsNullOrEmpty(s) &&
                              (!string.IsNullOrEmpty(p) && ((s[0] == p[0]) || (p[0] == '.')));

            if (p.Length >= 2 && p[1] == '*')
            {
                return (IsMatch(s, p.Substring(1)) || firstMatch && IsMatch(s.Substring(1), p));
            }
            else
            {
                return IsMatch(s.Substring(1), p.Substring(1));
            }
                

            return firstMatch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            bool result = sol.IsMatch("aa", "a*");
            Console.WriteLine(result);
        }
    }
}
