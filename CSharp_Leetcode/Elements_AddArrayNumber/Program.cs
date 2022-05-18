using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_AddArrayNumber
{
    class Program
    {
        public static void PlusOne(int[] a, int addNum)
        {
            int carry = 0;
            int digit = 0;


            for (int i = a.Length - 1; i >= 0; i--)
            {
                digit = addNum % 10;
                addNum = addNum / 10;

                int sum = a[i] + digit + carry;
                carry = 0;

                if (sum >= 10)
                {
                    int sumwithoutcarry = sum % 10;
                    carry = sum / 10;
                    a[i] = sumwithoutcarry;
                }
                else
                {
                    a[i] = sum;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] a = {1, 2, 9};
            PlusOne(a, 1);
        }
    }
}
