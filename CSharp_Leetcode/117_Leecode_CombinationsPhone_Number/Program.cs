using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117_Leecode_CombinationsPhone_Number
{
    public class Solution
    {
        //store the number to string map: program not complete

        private readonly Dictionary<int, string> codes = new Dictionary<int, string>()
        {
            {2, "abc"},
            {3, "def"},
            {4, "ghi"},
            {5, "jkl"},
            {6, "mno"},
            {7, "pqrs"},
            {8, "tuv"},
            {9, "wxyz"}

        };
        
        /*private string[][] codes = 
        {
            new string[]{"a","b","c"}, //<-- this is 23 <=> 01
            new string[]{"d","e","f"},
            new string[]{"g","h","i"},
            new string[]{"j","k","l"},
            new string[]{"m","n","o"},
            new string[]{"p","q","r","s"},
            new string[]{"t","u","v"},
            new string[]{"w","x","y","z"}
        };*/
        

        public IList<string> LetterCombinations(string digits)
        {
            string strResult;
            List<string> result = new List<string>();

            if (digits.Length == 0)
            {
                return result;
            }

            if (digits.Length == 1)
            {
                codes.TryGetValue(digits[0], out strResult);
                result.Add(strResult);
                return result;
            }

            List<string> combination = new List<string>();

            int level = 0;

            permutation(digits, codes, combination, result, level,0);
            return result;
        }

        private void permutation(string digits, Dictionary<int, string> codes, List<string> combination, 
                                  List<string> result, int level, int index)
        {
            if(level == digits.Length)
            {
                result.Add(string.Join("", combination));
                return;
            }
            int l = digits[level] - 50;

            for (int i = 0;i < codes[l].Length;i++)
            {
                //translation to level 
                l = digits[level] - 50;

                combination.Add(codes[l][i]);
                permutation(digits, codes, combination, result,level+1,i);
                combination.RemoveAt(combination.Count - 1);               
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            IList<string> result = sol.LetterCombinations("999");
            foreach(string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
