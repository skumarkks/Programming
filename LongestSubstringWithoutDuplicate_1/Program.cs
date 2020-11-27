using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutDuplicate_1
{
	public class Program
    {
        public static string LongestSubstringWithoutDuplication(string str)
        {
            // Write your code here

            if (str.Length == 0) return null;

            int[] longest = new int[] { 0, 1 };
            int startIdx = 0;
            Dictionary<char, int> lastseen = new Dictionary<char, int>();

            for (int endIdx = 0; endIdx < str.Length; endIdx++)
            {
                char ch = str[endIdx];
                if (lastseen.ContainsKey(ch))
                {
                    startIdx = Math.Max(startIdx, lastseen[ch] + 1);
                }

                lastseen[ch] = endIdx;
                if (longest[1] - longest[0] < endIdx - startIdx + 1)
                {
                    longest[0] = startIdx;
                    longest[1] = endIdx;
                }

            }

            return str.Substring(longest[0], longest[1] - longest[0] + 1);
        }

        public static void Main(string[] args)
        {
            string str = "clementia";
            string substring = Program.LongestSubstringWithoutDuplication(str);
            Console.WriteLine(substring);
        }
    }

}
