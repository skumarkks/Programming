using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IntToString
{
    class Program
    {
        public static string IntToString(int num)
        {
            bool sign = num < 0;
            StringBuilder resultString = new StringBuilder();

            try
            {
                if (num == 0)
                {
                    if (sign)
                    {
                        resultString.Append("-" + "0");
                        return resultString.ToString();
                    }
                    else
                    {
                        resultString.Append("0");
                        return resultString.ToString();
                    }
                }

                int tempNum = Math.Abs(num);

                while (tempNum != 0)
                {
                    int placeVal = tempNum % 10;
                    tempNum = tempNum / 10;

                    resultString.Append(placeVal);
                }

                if (sign)
                {
                    resultString.Append("-");
                }

                string resultStr = resultString.ToString();

                //Reverse the string
                char[] resultChar = resultStr.ToCharArray();

                for (int i = 0, j = resultStr.Length-1;
                    i <= j;
                    i++, j--)
                {
                    char temp = resultChar[i];
                    resultChar[i] = resultChar[j];
                    resultChar[j] = temp;
                }

                resultStr = resultChar.ToString();
                return resultStr;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return resultString.ToString();
        }

        static void Main(string[] args)
        {
            string str = IntToString(-432);
        }
    }
}
