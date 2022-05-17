using System;
using System.Collections.Generic;

namespace LonestUniqueCharacterSubstring
{
    public class Substring
    {
        public int FindLongestSubstring(string strInput, int k)
        {
            if (strInput.Length == 0) return 0;

            int start = 0;
            int end = 0;
            int maxLength = Int32.MinValue;

            char[] charInput = strInput.ToCharArray();
            var charMap = new Dictionary<char, int>();

            while(end < strInput.Length)
            {
                if (charMap.ContainsKey(strInput[end]))            
                {
                    charMap[strInput[end]] += 1;
                }
                else
                {
                    charMap.Add(strInput[end], 1);
                }

                if (charMap.Count == k)
                {
                    maxLength = Math.Max(maxLength, end - start + 1);
                }

                while (charMap.Count > k)
                {
                    charMap[strInput[start]] -= 1;
                    if (charMap[strInput[start]] == 0)
                        charMap.Remove(strInput[start]);
                    start++;
                }

                end++;
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            var test = new Substring();
            int result = test.FindLongestSubstring("araaci", 2);
            int expected = 4;
        
            if (result == expected)
            {
                Console.WriteLine("Passed Lenth: {0} ", result);
            }

            result = test.FindLongestSubstring("araaci", 1);
            expected = 2;

            if (result == expected)
            {
                Console.WriteLine("Passed Lenth: {0} ", result);
            }

            result = test.FindLongestSubstring("a", 1);
            expected = 1;

            if (result == expected)
            {
                Console.WriteLine("Passed Lenth: {0} ", result);
            }
        }
    }

}
