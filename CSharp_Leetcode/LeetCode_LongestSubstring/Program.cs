using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_LongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int i = 0, j = 0, ans = 0;
            var set = new HashSet<char>();
            while (i < n && j <n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                }
                else
                {
                    if (ans < (j - i))
                    {
                        ans = j - i;
                        i++;
                        j = i;
                        set = new HashSet<char>();
                    }
                    else
                    {
                        i++;
                        j = i;
                        set = new HashSet<char>();
                    }
                }
            }
            return ans;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            int i = sol.LengthOfLongestSubstring("pwwkew");
            Console.WriteLine(i);
        }
    }
}
