using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_ArrayReorder
{
    class Program
    {
        public class Test
        {
            public static int[] ArrayReorder(int[] a)
            {
                for (int i = 0, j = a.Length - 1; i < a.Length && j > i; i++)
                {
                    int remainderOdd = a[i] % 2;

                    if (remainderOdd > 0)
                    {
                        for (; j > i; j--)
                        {
                            int remainderEven = a[j] % 2;

                            if (remainderEven == 0)
                            {
                                swap(a, i, j);
                                break;
                            }
                        }
                    }
                }
                return a;

            }

            private static void swap(int[] a, int i, int j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 3, 2, 4, 5, 6, 9, 8 };
            int[] b = Test.ArrayReorder(a);
            foreach (int i in a)
                Console.WriteLine(i);
        }
    }
}
