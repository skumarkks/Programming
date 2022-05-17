using System;
using System.Collections.Generic;

namespace NonRepeatingSubString
{
    class Program
    {
		public class NoRepeatSubstring
        {
            public static int FindNoRepeatSubstring(string src)
            {
                if (src.Length == 0) return 0;

                int startIdx = 0;
                int maxLength = Int32.MinValue;
                Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();

                for (int endIdx = 0; endIdx < src.Length; endIdx++)
                {
                    char rightChar = src[endIdx];

                    if (charFrequencyMap.ContainsKey(rightChar))
                    {
                        startIdx = Math.Max(startIdx, charFrequencyMap[rightChar] + 1);
                        charFrequencyMap[rightChar] = endIdx;
                    }
                    else
                    {
                        charFrequencyMap.Add(rightChar, endIdx);
                    }

                    
                    maxLength = Math.Max(maxLength, endIdx - startIdx + 1);
                }

                return maxLength;
            }

            public static void Main(string[] args)
            {
                string testSrc1 = "aabccaa";
                int actualResult = 3;
                int expectedResult = NoRepeatSubstring.FindNoRepeatSubstring(testSrc1);
                if (actualResult == expectedResult)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("FAIL");

                }

                string testSrc2 = "a";
                actualResult = 1;
                expectedResult = NoRepeatSubstring.FindNoRepeatSubstring(testSrc2);
                if (actualResult == expectedResult)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("FAIL");

                }

                string testSrc3 = "aabcacaa";
                actualResult = 3;
                expectedResult = NoRepeatSubstring.FindNoRepeatSubstring(testSrc3);
                if (actualResult == expectedResult)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("FAIL");

                }

            }
        }

	}
}
