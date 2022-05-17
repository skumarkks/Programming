using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpaces
{
    class Program
    {
        public static char[] ReplaceSpace(char[] input, int charLength)
        {
            if (input.Length == 0) return null;
            int spaceCount = 0;

            for (int i = 0; i < charLength; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                    spaceCount++;
            }

            int length = charLength-1;
            int newLength = (charLength + spaceCount * 3)-1;

            int k = length;
            int j = newLength;

            while(j >= 0 && k >= 0)
            {
                char ch = input[k];
                if (ch == ' ')
                {
                    input[--j] = '0';
                    input[--j] = '2';
                    input[--j] = '%';
                }
                else
                    input[--j] = ch;

                k--;
            }

            return input;
        }

        static void Main(string[] args)
        {
            char[] test1 = new char[25];
            string test = "Suresh Kumar K S";

            for (int i = 0; i < 16; i++)
            {
                test1[i] = test[i];
            }

            char[] expected = "suresh%20Kumar%20K%20S".ToCharArray();
            char[] actual = Program.ReplaceSpace(test1, 16);

            Console.WriteLine(actual);
            Console.WriteLine(expected);
        }

    }
}
