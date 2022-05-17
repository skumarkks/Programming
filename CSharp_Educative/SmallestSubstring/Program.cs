using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestSubstring
{
    class Program
    {
        public static string SmallestSubstringContaining(string bigstring, string smallstring)
        {
            if (bigstring.Length < smallstring.Length) return null;

            Dictionary<char,int> targetCount = new Dictionary<char, int>();
            GetTargetCount(smallstring, targetCount);
            int[] smallestStringBounds = GetSmallestStringBounds(bigstring, targetCount);
            return GetSmallestsubString(bigstring, smallestStringBounds);
        }
        
        private static int[] GetSmallestStringBounds(string bigstring, Dictionary<char, int> targetCount)
        {
            int[] smallestStringBound = new[] {0, Int32.MaxValue};

            Dictionary<char,int> stringCount = new Dictionary<char, int>();
            
            int uniqueStringCount = targetCount.Count;
            int uniqueStringDone = 0;

            int leftIdx = 0;
            int rightIdx = 0;

            while (rightIdx < bigstring.Length)
            {
                char ch = bigstring[rightIdx];

                if (!targetCount.ContainsKey(ch))
                {
                    rightIdx++;
                    continue;
                }

                IncrementCount(ch, stringCount);

                if (targetCount[ch] == stringCount[ch])
                {
                    uniqueStringDone++;
                }

                while (uniqueStringCount == uniqueStringDone)
                {
                    if (rightIdx - leftIdx < smallestStringBound[1] - smallestStringBound[0])
                    {
                        smallestStringBound = new[] {leftIdx, rightIdx};
                    }

                    char leftch = bigstring[leftIdx];

                    if (stringCount.ContainsKey(leftch))
                    {
                        DecrementCount(leftch, stringCount);
                        uniqueStringDone--;
                        leftIdx++;
                    }
                    else
                    {
                        leftIdx++;
                    }
                }

                rightIdx++;

            }

            return smallestStringBound;
        }

        private static void DecrementCount(char leftch, Dictionary<char, int> stringCount)
        {
            if (stringCount.ContainsKey(leftch))
                stringCount[leftch] -= 1;
        }

        private static void IncrementCount(char ch, Dictionary<char, int> stringCount)
        {
            if (stringCount.ContainsKey(ch))
            {
                stringCount[ch] += 1;
            }
            else
            {
                stringCount.Add(ch,1);
            }
        }

        private static void GetTargetCount(string smallstring, Dictionary<char, int> targetCount)
        {
            foreach (char ch in smallstring)
            {
                if (targetCount.ContainsKey(ch))
                {
                    targetCount[ch] += 1;
                }
                else
                {
                    targetCount.Add(ch,1);
                }
            }
        }

        private static string GetSmallestsubString(string bigstring, int[] smallestStringBounds)
        {
            if (smallestStringBounds[1] == Int32.MaxValue) return null;
            return bigstring.Substring(smallestStringBounds[0], smallestStringBounds[1] - smallestStringBounds[0]+1);
        }

        static void Main(string[] args)
        {
            string bigstring = "abcd$ef$axb$c$";
            string smallstring = "$$abf";
            string substring = Program.SmallestSubstringContaining(bigstring, smallstring);
            Console.WriteLine(substring);


            bigstring = "abcd$e$axb$c$";
            smallstring = "$$abf";
            substring = Program.SmallestSubstringContaining(bigstring, smallstring);
            Console.WriteLine(substring);

            bigstring = "abcd";
            smallstring = "$$abf";
            substring = Program.SmallestSubstringContaining(bigstring, smallstring);
            Console.WriteLine(substring);
        }
    }
}
