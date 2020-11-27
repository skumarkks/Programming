using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{

    class Program
    {
        //time: O(nlogn) space O(1)
        public static bool IsPermutationSol1(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            var charStr1 = str1.ToCharArray();
            var charStr2 = str2.ToCharArray();

            Array.Sort(charStr1);
            Array.Sort(charStr2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (charStr1[i] != charStr2[i]) return false;
            }

            return true;
        }

        //Time O(n) and space O(n) where n is the size of the string
        public static bool IsPermutationSol2(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> charMap = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char rightChar = str1[i];
                if (charMap.ContainsKey(rightChar))
                {
                    charMap[rightChar] += 1;
                }
                else
                    charMap.Add(rightChar, 1);
            }

            for (int i = 0; i < str2.Length; i++)
            {
                char rightChar = str2[i];

                if (charMap.ContainsKey(rightChar))
                {
                    charMap[rightChar] -= 1;
                    if (charMap[rightChar] == 0)
                        charMap.Remove(rightChar);
                }
                else
                {
                    return false;
                }
            }

            return true;

        }

        public static string stringify(string str, string stringify, int trueLength)
        {
            if (str.Length == 0) return null;

            char[] strChar = str.ToCharArray();
            int j = strChar.Length - 1;
            int i = strChar.Length - 1;

            for (i = strChar.Length-1; i >= 0; i--)
            {
                if (strChar[i] != ' ') break;
                
            }

            while (i >= 0)
            {
                if (strChar[i] != ' ')
                {
                    strChar[j] = strChar[i];
                    j--;
                }
                else
                {
                    for (int k = stringify.Length - 1; k >= 0; k--)
                    {
                        strChar[j] = stringify[k];
                        j--;
                    }
                }

                i--;
            }

            for (;j >= 0; j--)
            {
                strChar[j] = ' ';

            }

            return new string(strChar);
        }

        //Time Complexity O(n) and space complexity O(n) where n is the number of characters in the string
        public static bool IsPermutationAPalindrome(string str)
        {
            if (str.Length == 0) return false;

            int oddCount = 0;
            Dictionary<char, int> charfreq = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char rightChar = str[i];
                if (charfreq.ContainsKey(rightChar))
                {
                    charfreq[rightChar] += 1;
                    if (charfreq[rightChar] % 2 == 1)
                    {
                        oddCount++;
                    }
                    else
                    {
                        oddCount--;
                    }
                }
                else
                {
                    charfreq.Add(rightChar, 1);
                    oddCount++;
                }
            }

            return oddCount <= 1;
        }

        static void Main(string[] args)
        {
            Test.Test3();

        }
    }

    public class Test
    {
        public static void Test1()
        {
            bool isPerm = Program.IsPermutationSol1("Suresh", "huresS");
            Console.WriteLine(isPerm);

            isPerm = Program.IsPermutationSol1("Suresh", "Sureah");
            Console.WriteLine(isPerm);

            isPerm = Program.IsPermutationSol1("Suresh", "Surea h");
            Console.WriteLine(isPerm);

            isPerm = Program.IsPermutationSol2("Suresh", "huresS");
            Console.WriteLine(isPerm);

            isPerm = Program.IsPermutationSol2("Suresh", "Sureah");
            Console.WriteLine(isPerm);

            isPerm = Program.IsPermutationSol2("Suresh", "Surea h");
            Console.WriteLine(isPerm);
        }

        public static void Test2()
        {
            string str = Program.stringify("Suresh Kumar K S         ", "%20", 26);
            Console.WriteLine(str);
        }

        public  static void Test3()
        {
            bool isTest = Program.IsPermutationAPalindrome("malaayalam");
            Console.WriteLine(isTest);

        }
    }

}



