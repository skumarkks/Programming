using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMerge
{
    class Program
    {

        public static int[] ArrayMerge(int[] a, int[] b)
        {
            int[] c =new int[a.Length+b.Length];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }

            for (; i < a.Length;) c[k++] = a[i++];
            for (; j < b.Length;) c[k++] = b[j++];
            return c;
        }
        static void Main(string[] args)
        {
            int[] a = new[] {3,8,16,20,25 };
            int[] b = new[] {3,10,12,22,33};
            int[] c = ArrayMerge(a, b);
            foreach (var i in c)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
