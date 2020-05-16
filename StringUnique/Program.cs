using System;

namespace StringUnique
{
    class Program
    {
        public static bool IsUniqueString(string str)
        {
            if (str.Length == 0) return false;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string StringReverse(string str)
        {
            char[] charStr = str.ToCharArray();

            for (int i = 0, j = charStr.Length - 1; i < j; i++, j--)
                Swap(charStr, i, j);

            str = new string(charStr);
            return str;
        }

        private static void Swap(char[] charStr, int i, int j)
        {
            char temp = charStr[i];
            charStr[i] = charStr[j];
            charStr[j] = temp;            
        }

        static void Main(string[] args)
        {
            bool result = Program.IsUniqueString("suresh");
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");

            string str = "gotcha";
            string resStr = Program.StringReverse(str);
            Console.WriteLine(resStr);
        }
    }
}
