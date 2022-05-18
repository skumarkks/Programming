using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_licenseKeyFormatting
{
    class Program
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            S = S.Replace("-", "");
            // declare another char[] of string length.
            int len = 0;
            if (S.Length % K == 0)
            {
                len = (S.Length + Math.Abs(S.Length / K))-1;
            }
            else
            {
                len = (S.Length + Math.Abs(S.Length / K));
            }

            char[] sArray = new char[len];

            // loop through the given string
            int count = 0;

            for(int i = S.Length-1, j = len-1; i >= 0; i--, j--)
            {
                if (count != K)
                {
                    if (S[i] != '-')
                    {
                        sArray[j] = char.ToUpper(S[i]);
                        count++;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    sArray[j] = '-';
                    count = 0;
                    i++;
                }
            }
            return new string(sArray).TrimStart('\0');
        }

        static void Main(string[] args)
        {

            var prg = new Program();
            string str = prg.LicenseKeyFormatting("SF3Z-2e-9-w", 4);

        }
    }
}
