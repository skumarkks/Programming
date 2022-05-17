using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherEncryptor
{
    class Program
    {
        public static string CaesarCypherEncryptor(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;

            for (int i = 0; i < newLetters.Length; i++)  
            {
                newLetters[i] = GetNewCharacter(str[i], newKey);
            }

            return newLetters.ToString();
        }

        public static char GetNewCharacter(char ch, int Key)
        {
            int position = ch + Key;
            return position <= 'z' ? (char) position : (char) ('a'-1 + position % 'z');
        }

        //public static char GetNewCharacter(char ch, int key)
        //{
        //    int totalLetters = 26;
        //    int position = ch - 'a' + key;

        //    if (position >= totalLetters)
        //    {
        //        int relativePosition = Math.Abs(totalLetters - position);
        //        int newPosition = 'a' + relativePosition;

        //        return (char)newPosition;
        //    }

        //    return (char)(position + 'a');
        //}

        static void Main(string[] args)
        {
            string str = "xyz";
            string newString = Program.CaesarCypherEncryptor(str,2);
            Console.WriteLine(newString);
        }
    }
}
