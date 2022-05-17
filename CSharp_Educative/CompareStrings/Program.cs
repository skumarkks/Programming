using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new Program();
            bool matched = prg.CompareStrings("xy#z", "xzy#");
            Console.WriteLine("Hello World!");
        }

        public bool CompareStrings(string str1, string str2)
        {
            int index1 = str1.Length-1;
            int index2 = str2.Length-1;
            bool matched = false;

            while(index1 < str1.Length || index2 < str2.Length)
            {
                
                char str1ch = GetCharacter(str1, index1);
                char str2ch = GetCharacter(str2, index2);

                if (str1ch == str2ch)
                    matched = true;
                else
                    matched = false;


                if (index1 > str1.Length || index2 > str2.Length)
                    return false;
            }
            return matched;
        }

        private char GetCharacter(string str, int index)
        {
            while(str[index] == '#')
            {
                backspace++;
            }
            
        }
    }
}
