using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutation
{
    class Program
    {
        //Time Complexity O(n) space complexity O(n)
        public static bool IsStringPermutation_sol1(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length == 0) return false;
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> charMap = new Dictionary<char, int>();

            // add str1 element to a hash map
            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];
                if (charMap.ContainsKey(ch))
                {
                    charMap[ch] += 1;
                }
                else
                {
                    charMap.Add(ch, 1);
                }
            }

            // check is str2 elment exist in hashmap
            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];
                if (charMap.ContainsKey(ch))
                {
                    charMap[ch] -= 1;
                    if (charMap[ch] == 0)
                        charMap.Remove(ch);
                }
                else
                {
                    return false;
                }
            }

            return (charMap.Count == 0);
        }

        public static bool IsStringPermutation_sol2(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length == 0) return false;
            if (str1.Length != str2.Length) return false;

            char[] chstr1 = str1.ToCharArray();
            char[] chstr2 = str2.ToCharArray();

            Array.Sort(chstr1);
            Array.Sort(chstr2);

            int str1Idx = 0;
            int str2Idx = 0;

            while (str1Idx < str1.Length && str2Idx < str2.Length)
            {
                char ch1 = chstr1[str1Idx];
                char ch2 = chstr2[str2Idx];

                if (ch1 == ch2)
                {
                    str1Idx++;
                    str2Idx++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            {
                string test1 = "suresh";
                string test2 = "sshure";

                bool result = Program.IsStringPermutation_sol1(test1, test2);

                if (result == true)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }


                string test3 = "suresh";
                string test4 = "sshur";

                result = Program.IsStringPermutation_sol1(test3, test4);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }

                string test5 = "suresh";
                string test6 = "s";

                result = Program.IsStringPermutation_sol1(test5, test6);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }

                string test7 = "";
                string test8 = "";

                result = Program.IsStringPermutation_sol1(test7, test8);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            
            Console.WriteLine("Changing Solution");

            {
                string test1 = "suresh";
                string test2 = "sshure";

                bool result = Program.IsStringPermutation_sol2(test1, test2);

                if (result == true)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }


                string test3 = "suresh";
                string test4 = "sshur";

                result = Program.IsStringPermutation_sol2(test3, test4);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }

                string test5 = "suresh";
                string test6 = "s";

                result = Program.IsStringPermutation_sol2(test5, test6);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }

                string test7 = "";
                string test8 = "";

                result = Program.IsStringPermutation_sol2(test7, test8);

                if (result == false)
                    Console.WriteLine("Pass");
                else
                {
                    Console.WriteLine("Fail");
                }
            }
        }
    }
}
