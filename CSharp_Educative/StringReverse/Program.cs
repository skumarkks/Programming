using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        public static char[] StringReverse(char[] strInput)
        {
            if (strInput.Length == 0) return null;

            int leftIdx = 0;
            int rightIdx = strInput.Length - 1;

            while (leftIdx < rightIdx)
            {
                Swap(leftIdx, rightIdx, strInput);
                leftIdx++;
                rightIdx--;
            }

            return strInput;
        }

        public static void Swap(int from, int to, char[] strInput)
        {
            char temp = strInput[from];
            strInput[from] = strInput[to];
            strInput[to] = temp;
        }
        static void Main(string[] args)
        {
            string test = "Suresh Kumar";
            char[] result = Program.StringReverse(test.ToCharArray());

            if (result == "ramuK hseruS".ToCharArray())
            {
                Console.WriteLine("PASS");
            }
        }
    }
}
