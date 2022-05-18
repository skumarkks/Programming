using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_CompressString
{
    class Program
    {
        public static string CompressStringBad(string srcStr)
        {

            if (srcStr == null)
                return null;
            if (srcStr.Length == 1)
                return srcStr + srcStr.Length;
            char last = srcStr.ElementAt(0);

            int count = 1;
            StringBuilder compStr = new StringBuilder();

            for(int i = 1; i < srcStr.Length; i++)
            {
                if(srcStr.ElementAt(i) == last)
                {
                    count++;
                }
                else
                {
                    compStr.Append(last);
                    compStr.Append(count);
                    last = srcStr.ElementAt(i);
                    count = 1;
                }
            }
            compStr.Append(last);
            compStr.Append(count);

            return compStr.ToString();
        }
        static void Main(string[] args)
        {
            //string compressString = CompressStringBad("aabcccccaa");
            string compressString = CompressStringBad("aabccdeeaa");
            Console.WriteLine(compressString);
        }
    }
}
