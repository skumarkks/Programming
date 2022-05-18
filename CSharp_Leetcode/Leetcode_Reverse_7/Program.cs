using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 123
// 321
namespace Leetcode_Reverse_7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            bool sign = false;

            if (x < 0)
                sign = true;

            int y = Math.Abs(x);

            int rev_num = 0; ;

            while (y > 0)
            {
                rev_num = rev_num * 10 + y % 10;
                y = y / 10;
            }

            if (sign)
                rev_num = rev_num * -1;
            return rev_num;

            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            int r = sol.Reverse(-2147483648);

        }
    }
}
