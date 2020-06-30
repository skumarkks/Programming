using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyAndGroupAnagrams
{
    class Program
    {
        public static List<List<string>> GroupAnagrams(string[] words)
        {
            if (words.Length == 0) return null;

            // Space complexity O(w) to store w words
            Dictionary<string,List<string>> anagrams = new Dictionary<string, List<string>>();

            // time complexity O(wnlogn) where w is the number of words
            foreach (var word in words)
            {
                // Sort each word in  the list 
                // for sorting O(nlogn) time where n is the length of the longest string
                char[] charWord = word.ToCharArray();
                Array.Sort(charWord);
                string sortedWord = new string(charWord);

                if (anagrams.ContainsKey(sortedWord))
                {
                    anagrams[sortedWord].Add(word);
                }
                else
                {
                    anagrams[sortedWord] = new List<string>(){word};
                }
            }

            return anagrams.Values.ToList();
        }

        static void Main(string[] args)
        {
            string[] words = new string[] { "yo", "act", "flop", "tac", "cat", "oy", "olfp" };
            var groupByAnagrams= Program.GroupAnagrams(words);

            foreach (var anagram in groupByAnagrams)
            {
                foreach (var word in anagram)
                {
                    Console.Write("{0} ",word);
                }

                Console.WriteLine();
            }

        }
    }
}
