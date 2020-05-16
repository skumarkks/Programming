using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutDuplicate
{
    public struct Result
    {
        public int start;
        public int end;
    }

    public class Substring
    {
        public int FindLongestUniqueSubstring(string strInput, out string substring)
        {
            substring = null;
            if (strInput.Length == 0) return 0;
            if (strInput.Length == 1) return 1;

            int start = 0;
            int end = 0;
            int maxLength = 0;
            Result result = new Result();
            var charMap = new Dictionary<char, int>();

            char[] charInput = strInput.ToCharArray();

            while (end < strInput.Length)
            {
                if (charMap.ContainsKey(charInput[end]))
                {
                    start = Math.Max(start, charMap[charInput[end]] + 1);
                    charMap[charInput[end]] = end;

                }
                else
                {
                    charMap.Add(charInput[end], end);
                }

                int preMax = maxLength;
                maxLength = Math.Max(maxLength, end - start + 1);
                if (preMax != maxLength)
                {
                    result.start = start;
                    result.end = end;
                }
                end++;
            }

            substring = strInput.Substring(result.start, maxLength);
            return maxLength;
        }

        static void Main(string[] args)
        {
            var test = new Substring();
            string resultString = null;
            int maxLength = test.FindLongestUniqueSubstring("clementisacap", out resultString);

            

        }

    }

}
