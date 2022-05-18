using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Elements_StringToInteger
{
    class Program
    {
        public static  int StringToInteger(string s1)
        {
            if (string.IsNullOrEmpty(s1) || s1.Length == 0)
                return 0;

            double result = 0;
            int startIndex = 0;

            bool IsNagative = false;

            // start index
            if (s1[0] == '+' || s1[0] == '-')
                startIndex = 1;

            if (s1[0] == '-')
                IsNagative = true;

            //Normal case
            for (int i = startIndex; i < s1.Length; i++)
            {   
                //If there is an alphacharacter
                if (s1[i] < '0' || s1[i] > '9')
                {
                    result = 0;
                    break;
                }
                //converting to int
                int digitvalue = s1[i] - '0';
                result = result * 10 + digitvalue;
            }

            if (IsNagative)
                result = result * -1;

            if (result > Int32.MaxValue)
                return Int32.MaxValue;
            if (result < Int32.MinValue)
                return Int32.MinValue;

            return (int)result;

        }
        static void Main(string[] args)
        {
            int number = StringToInteger("-12A3");
        }
    }
}
