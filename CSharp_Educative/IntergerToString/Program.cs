/*
 * given an interger convert to string.
 * Approach
 * dividing the string by the base of the number 
 * get the remainder and and concat to a string
 * 
 * the quotient get again divide by the base of the numnber
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergerToString
{
    public class Program
    {
        public string IntergerToString(int num)
        {
            //StringBuilder sb = new StringBuilder();
            //while(num != 0)
            //{
            //    int quotient = num % 10;
            //    num = num / 10;                
            //    sb.Append(quotient);
            //}

            //var result = new string(sb.ToString().Reverse());

            //return result.ToString();

            return null;
        }

        static void Main(string[] args)
        {
            var sol = new Program();
            string str = sol.IntergerToString(152);
            Console.WriteLine(str);

        }
    }
}
