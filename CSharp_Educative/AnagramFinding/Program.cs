using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramFinding
{
    class Solution
    {
        public static List<int[]> FindAnagrams(string str, string pattern)
        {
            if (str.Length < pattern.Length) return null;
            Dictionary<char, int> counts = getPatternCounts(pattern);
            return getAnagrams(str, pattern, counts);

        }

        public static List<int[]> getAnagrams(string str, string pattern, Dictionary<char, int> counts)
        {
            int leftIdx = 0;
            int rightIdx = 0;
            Dictionary<char, int> lastseen = new Dictionary<char, int>();
            List<int[]> resultBounds = new List<int[]>();

            int uniquetotalCount = counts.Count;
            int uniquetotalDone = 0;

            while (rightIdx < str.Length)
            {
                char rightch = str[rightIdx];

                IncrementCount(rightch, lastseen);

                if (counts.ContainsKey(rightch) && counts[rightch] == lastseen[rightch])
                {
                    uniquetotalDone++;
                }

                if (uniquetotalDone == uniquetotalCount)
                {
                    int[] bounds = new int[] { leftIdx, rightIdx };
                    resultBounds.Add(bounds);
                }
                
                if(rightIdx >= pattern.Length-1)
                {
                    char leftch = str[leftIdx];
                    DecrementCount(leftch, lastseen);

                    if (counts.ContainsKey(leftch) && counts[leftch] != lastseen[leftch])
                        uniquetotalDone--;

                    leftIdx++;
                }

                rightIdx++;
            }

            return resultBounds;

        }

        public static void DecrementCount(char ch, Dictionary<char, int> lastseen)
        {
            if (lastseen.ContainsKey(ch))
            {
                lastseen[ch] -= 1;
            }
        }


        public static void IncrementCount(char ch, Dictionary<char, int> lastseen)
        {
            if (lastseen.ContainsKey(ch))
            {
                lastseen[ch] += 1;
            }
            else
                lastseen.Add(ch, 1);
        }

        public static Dictionary<char, int> getPatternCounts(string pattern)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char ch in pattern)
            {
                if (counts.ContainsKey(ch))
                {
                    counts[ch] += 1;
                }
                else
                    counts.Add(ch, 1);
            }
            return counts;
        }


        static void Main(string[] args)
        {

            string str = "abpbcabc";
            string pattern = "abc";

            var result = Solution.FindAnagrams(str, pattern);

            foreach (int[] item in result)
            {
                Console.Write("{0 } {1 }", item[0], item[1]);
                Console.WriteLine();
            }

        }
    }

}
