using System;
using System.Collections.Generic;

namespace NonRepeatingSubarray
{
    class Program
    {
        public int NonRepeatingSubarray(string str, int k)
        {
            int windowsStart = 0;
            var charFrequencyMap = new Dictionary<char, int>();
            int maxLengthUnique = 0;

            for (int windowsEnd = 0; windowsEnd < str.Length; windowsEnd++)
            {
                if (charFrequencyMap.ContainsKey(str[windowsEnd]))
                {
                    maxLengthUnique = Math.Max(maxLengthUnique, windowsEnd - windowsStart);
                    windowsStart = Math.Max(windowsStart, charFrequencyMap[str[windowsEnd]] + 1);
                }
                else
                {
                    charFrequencyMap.Add(str[windowsEnd], windowsEnd);
                }

                if(windowsEnd-windowsEnd+1-maxLengthUnique >= k)
                {
                    charFrequencyMap[str[windowsStart]] -= 1;
                    if(charFrequencyMap[str[windowsStart]] == 0)
                    {
                        charFrequencyMap.Remove(str[windowsStart]);
                    }
                    windowsStart++;
                }

                return maxLengthUnique;
            }

            return maxLengthUnique;
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            //int result = prg.NonRepeatingSubarray("abccde");

            Console.WriteLine(result);
        }
    }
}
