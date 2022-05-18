using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_Anagram
{
    class Program
    {
        // if the length of two string are not the same, they can not form an anagram.
        //

        public static bool IsAnagram(string s1, string s2)
        {
            char[] s1Char = s1.ToCharArray();
            char[] s2Char = s2.ToCharArray();

            for (int i = 0, j = s1.Length-1; i < s1.Length && j <= 0; i++, j--)
            {
                if (s1Char[i] != s2Char[j])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool result = IsAnagram("god", "dog");
            Console.WriteLine(result);
        }
    }
}
