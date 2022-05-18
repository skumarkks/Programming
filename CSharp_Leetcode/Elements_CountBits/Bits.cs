using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_CountBits
{
    public class Bits
    {
        public int BitCount(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num & 1;
                num = num >> 1;
            }

            return sum;
        }

        

        static void Main(string[] args)
        {
            Bits bits = new Bits();
            int sum = bits.BitCount(154);
            Console.WriteLine(sum);

            
        }
    }
}
