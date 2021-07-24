using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaion_EduSubset
{
    class Program
    {
        

        //Time complexity O(N*2^N)
        //space complexity (2^N)
        public static List<string> FindPermutations(string str)
        {
            if (str.Length == 0) return null;

            char[] charStr = str.ToCharArray();

            List<string> permutations = new List<string>();
            permutations.Add(str);

            for (int i = 0; i < str.Length; i++) //-->O(N)
            {
                if (char.IsDigit(charStr[i])) continue;

                char upper = char.ToUpper(charStr[i]);
                int count = permutations.Count;

                for (int j = 0; j < count; j++)// --> O(2^N)
                {
                    char[] temp = permutations.ElementAt(j).ToCharArray();
                    temp[i] = upper;
                    permutations.Add(new string(temp));
                }
            }

            return permutations;
        }
        static void Main(string[] args)
        {
            string test = "ab7c";
            List<string> results = FindPermutations(test);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
