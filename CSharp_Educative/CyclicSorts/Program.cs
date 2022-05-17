using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicSorts
{
    class Program
    {

        public static int[] CyclicSorts(int[] num)
        {
            if (num.Length == 0) return null;
            int i = 0;

            while (i < num.Length)
            {
                if (i + 1 == num[i])
                {
                    i++;
                    continue;
                }
                else
                    Swap(num,i, num[i]-1);

            }
            return num;
            
        }

        public static  void Swap(int[] num, int i, int j)
        {
            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }
        static void Main(string[] args)
        {
            int[] num = new int[] {2, 4, 5, 1, 3};
            int[] temp = CyclicSorts(num);
            foreach (var i in temp)
            {
                Console.WriteLine("{0 }",i);
            }

        }
    }
}
