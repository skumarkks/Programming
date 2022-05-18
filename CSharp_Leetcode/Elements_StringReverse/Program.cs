using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_StringReverse
{
    class Program
    {
        public static string StringReverse(string a)
        {
            char[] s = a.ToCharArray();
            if (s == null)
            {
                throw new NullReferenceException();
            }

            for (int i = 0, j = s.Length - 1;
                i < s.Length-1 && j >= i;
                i++, j--)
            {
                char ch = s[i];
                s[i] = s[j];
                s[j] = ch;
            }

            string ret = s.ToString();
            return ret;
        }
        static void Main(string[] args)
        {
            string reverseString = StringReverse("Sures");
        }
    }
}
