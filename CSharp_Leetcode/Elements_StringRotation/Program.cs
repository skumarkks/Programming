using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_StringRotation
{
    class Program
    {
        public static bool IsRotatedString(string s1, string s2)
        {
            if ((s1.Length == s2.Length) && (s1 != null && s2 != null))
            {
                string s1s1 = s1 + s1;
                if (s1s1.Contains(s2))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            bool result = IsRotatedString("WaterBottle", "erBottleWat");
        }
    }
}
