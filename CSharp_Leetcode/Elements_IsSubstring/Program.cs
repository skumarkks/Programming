using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IsSubstring
{
    class Program
    {
        public static bool IsSubstring(string t, string s)
        {
            // if the given string is empty
            if(string.IsNullOrEmpty(t)||
               string.IsNullOrEmpty(s))
                    return false;
            //if the source length is less than givne substring length 
            if (t.Length < s.Length)
                return false;

            var IsSubString = false;

            var startIndex = 0;
            var endIndex = 0;

            // find first occurance of the substring
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[0])
                {
                    startIndex = i;
                    for (int j = 1, k = i+1; j < s.Length; j++, k++)
                    {
                        if (t[k] == s[j])
                        {
                            IsSubString = true;
                            endIndex = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                // checking a part of the substring matches only
                startIndex = startIndex + 1;
                endIndex = startIndex + endIndex;

                if ((endIndex - startIndex)+1 != s.Length)
                    IsSubString = false;

                if (IsSubString)
                {
                    break;
                }
            }

            

            return IsSubString;
        }
        static void Main(string[] args)
        {
            bool aSubString = false;

            //aSubString = IsSubstring("GACGCCA", "CGC");

            //aSubString = IsSubstring("NITIN Suresh Kumar  ", "esh Kum");

            aSubString = IsSubstring("abcdabcabcdf", "cabcdf");

            Console.WriteLine(aSubString);
        }
    }
}
