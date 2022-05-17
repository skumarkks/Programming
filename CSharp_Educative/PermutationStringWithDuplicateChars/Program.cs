using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationStringWithDuplicateChars
{
    class Program
    {
        public List<List<string>> Permutation(char[] input)
        {
            if (input.Length == 0) return null;

            Array.Sort(input);
            var chFrequency = new Dictionary<char, int>();

            foreach (var ch in input)
            {
                if(!chFrequency.ContainsKey(ch))
                    chFrequency.Add(ch,0);
                chFrequency[ch] += 1;
            }

            char[] chSet = new char[chFrequency.Count];
            int[] chVal = new int[chFrequency.Count];

            int nextId = 0;
            foreach (var item in chFrequency)
            {
                chSet[nextId] = item.Key;
                chVal[nextId] = item.Value;
                nextId += 1;
            }

            var results = new List<List<string>>();
            char[] result = new char[input.Length];
            int level = 0;

            PermutationUtil(chSet, chVal, results, result,level);

            return results;
        }

        private void PermutationUtil(char[] chSet, int[] chVal, List<List<string>> results, char[] result, int level)
        {
            if (level == result.Length)
            {
                var curResult = new List<string>();
                curResult.Add(new string(result));
                results.Add(curResult);
            }
            else
            {
                for (int i = 0; i < chSet.Length; i++)
                {
                    if (chVal[i] > 0)
                    {
                        result[level] = chSet[i];
                        chVal[i] -= 1;
                        PermutationUtil(chSet, chVal, results, result, level+1);
                        chVal[i] += 1;
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            var sol = new Program();
            var input = "AABC".ToCharArray();
            var results = sol.Permutation(input);

           for(int i =0; i < results.Count;i++)
           {
                Console.WriteLine(results[i][0]);
           }

        }
    }
}
