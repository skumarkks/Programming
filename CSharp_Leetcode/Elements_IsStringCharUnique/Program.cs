using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IsStringCharUnique
{
    class Program
    {
        public static bool IsStringUnique(string s)
        {
            if (s == null)
            {
                throw new NullReferenceException();
            }

            if (s != null)
            {
                int uniqueChecker = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    int val = s[i] - 'a';

                    if ((uniqueChecker & (1 << val)) > 0)
                        return false;
                    else
                    {
                        uniqueChecker |= (1 << val);
                    }
                }

                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            bool checker = Program.IsStringUnique(null);
        }
    }
}
