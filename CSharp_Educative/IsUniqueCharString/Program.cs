using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUniqueCharString
{
    class Program
    {
        public static bool IsUniqueCharString(string strInput)
        {
            if (strInput.Length == 0) return false;

            Boolean[] charMap = new bool[256];
            for (int i = 0; i < charMap.Length; i++)
            {
                charMap[i] = false;
            }

            strInput = strInput.ToLower();
            for (int i = 0; i < strInput.Length; i++)
            {
                int val = strInput[i];

                if (charMap[val] == false)
                {
                    charMap[val] = true;
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
            bool result = Program.IsUniqueCharString("Suresh");
            Console.WriteLine(result);
            result = Program.IsUniqueCharString("kumar");
            Console.WriteLine(result);

        }
    }
}
