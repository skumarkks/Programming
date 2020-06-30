using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExistPalindromePermutaion
{
    class Program
    {
        public static bool IsPermutaionPalindrome_Sol1(string strInput)
        {
            if (strInput.Length == 0) return false;

            var charMap = BuildMap(strInput);
            return CheckEvenOdd(strInput, charMap);
        }

        public  static Dictionary<char, int> BuildMap(string strInput)
        {
            char[] chInput = strInput.ToLower().ToCharArray();
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            for (int i = 0; i < chInput.Length; i++)
            {
                char ch = chInput[i];
                if (ch != ' ' && charMap.ContainsKey(ch))
                {
                    charMap[ch] += 1;
                }
                else if (ch != ' ')
                {
                    charMap.Add(ch, 1);
                }


            }

            return charMap;
        }

        public static bool CheckEvenOdd(string strInput, Dictionary<char, int> charMap)
        {
            bool isEven = false;
            bool isOdd = false;
            int length = 0;

            char[] chInput = strInput.ToLower().ToCharArray();
            for (int i = 0; i < chInput.Length; i++)
            {
                char ch = chInput[i];
                if (ch != ' ') length++;
                if (ch == ' ')
                    continue;

                int count = charMap[ch];

                if (count % 2 == 0)
                {
                    isEven = true;
                }
                else
                {
                    if (isOdd) return false;
                    isOdd = true;
                }
            }

            if (length % 2 == 0)
            {
                if (isEven && !isOdd)
                    return true;
            }
            else
            {
                if (isEven && isOdd)
                    return true;
            }

            return false;
        }

        public static int[] BuildcharMap(string strInput)
        {
            if (strInput.Length == 0) return null;
            char[] chInput = strInput.ToLower().ToCharArray();

            int[] charMap = new int['z'-'a'+1];

            for (int i = 0; i < chInput.Length; i++)
            {
                char ch = chInput[i];

                int val = ch - 'a';

                if (val < 0 || val > 25) continue;

                charMap[val] += 1;
            }

            return charMap;
        }

        public static bool IsPermutaionPalindrome_Sol2(string strInput)
        {
            if (strInput.Length == 0) return false;

            char[] chInput = strInput.ToLower().ToCharArray();
            int countOdd = 0;
            
            int[] newChaMap = BuildcharMap(strInput);

            Dictionary<char, int> charMap = new Dictionary<char, int>();

            for (int i = 0; i < chInput.Length; i++)
            {
                char ch = chInput[i];

                if (ch == ' ') continue;
                if (charMap.ContainsKey(ch))
                {
                    charMap[ch] += 1;
                }
                else
                {
                    charMap.Add(ch, 1);
                }

                if (charMap[ch] % 2 == 1)
                    countOdd++;
                else
                {
                    countOdd--;
                }

            }
            return countOdd <= 1;
        }

        static void Main(string[] args)
        {
            

            {
                string strInput = "Tact Coa";

                bool isExistPalindrome = Program.IsPermutaionPalindrome_Sol1(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);

                strInput = "cat";

                isExistPalindrome = Program.IsPermutaionPalindrome_Sol1(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);

                strInput = "addogbbga";

                isExistPalindrome = Program.IsPermutaionPalindrome_Sol1(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);
            }

            {
                Console.WriteLine("Solution 2\n");
                string strInput = "Tact Coa";

                bool isExistPalindrome = Program.IsPermutaionPalindrome_Sol2(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);

                strInput = "cat";

                isExistPalindrome = Program.IsPermutaionPalindrome_Sol2(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);

                strInput = "addogbbga";

                isExistPalindrome = Program.IsPermutaionPalindrome_Sol2(strInput);
                Console.WriteLine(isExistPalindrome ? true : false);

            }
        }
    }
}
