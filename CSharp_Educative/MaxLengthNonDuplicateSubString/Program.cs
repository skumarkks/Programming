using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLengthNonDuplicateSubString
{
    class Program
    {
        public static string LongestSubstringWithoutDuplication(string str)
        {

            int maxLength = Int32.MinValue;
            int[] result = null;

            Dictionary<char, int> letterMap = new Dictionary<char, int>();
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                if (letterMap.ContainsKey(rightChar))
                {
                    windowStart = Math.Max(windowStart, letterMap[rightChar] + 1);
                    
                }

                letterMap[rightChar] = windowEnd;

                int previousLength = maxLength;

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);

                if (maxLength > previousLength)
                {
                    result = new int[] { windowStart, windowEnd };
                }

            }

            return str.Substring(result[0], result[1] - result[0]+1);

        }

        static void Main(string[] args)
        {
            string test1 = "clementisacap";
            string result = Program.LongestSubstringWithoutDuplication(test1);
            Console.WriteLine(result);
        }
    }
}
