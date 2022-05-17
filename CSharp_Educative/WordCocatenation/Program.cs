using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordConcatenation
{
    class Program
    {
    
        public static List<int> FindWordConcatenation(string str, string[] words)
        {
            if (str.Length == 0) return new List<int>();

            Dictionary<string, int> wordfrequencymap = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordfrequencymap.ContainsKey(word))
                {
                    wordfrequencymap[word] += 1;
                }
                else
                {
                    wordfrequencymap.Add(word, 1);
                }
            }


            int wordcount = words.Length;
            int wordlength = words[0].Length;
            List<int> resultIndices = new List<int>();
            int firstloop = 0;
            int secondloop = 0;

            for (int i = 0; i <= str.Length - wordcount * wordlength; i++)
            {
                Dictionary<string, int> wordseen = new Dictionary<string, int>();
                firstloop++;

                for (int j = 0; j < str.Length; j++)
                {
                    secondloop++;

                    int nextwordindex = i + j * wordlength;

                    if (nextwordindex + wordlength > str.Length) break;

                    string word = str.Substring(nextwordindex,  wordlength);

                    if (!wordfrequencymap.ContainsKey(word)) break;

                    if (wordseen.ContainsKey(word))
                    {
                        wordseen[word] += 1;
                    }
                    else
                    {
                        wordseen.Add(word, 1);
                    }

                    if (wordseen[word] > wordfrequencymap[word])
                        break;

                    if (j + 1 == wordcount)
                        resultIndices.Add(i);
                }
            }

            Console.WriteLine(firstloop);
            Console.WriteLine(secondloop);

            return resultIndices;

        }

        static void Main(string[] args)
        {
            string str = "catfoxcat";
            string[] words = new string[]{"cat","fox"};
            var result = Program.FindWordConcatenation(str, words);

            foreach(var res in result)
                Console.WriteLine(res);

        }
    }
}
