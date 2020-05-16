using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMaxNumberinArray
{
    class Program
    {
        public static int[] FindKMax(int[] arr, int k)
        {
            if (arr.Length == 0 || k < 1) return null;
            int[] temp = new int[k];
            int i = 0;
            for (i = 0; i < k; i++)
            {
                temp[i] = arr[i];
            }

            Array.Sort(temp);
            int min = temp[0];

            for (int j = i; j < arr.Length; j++)
            {
                if(arr[j] > min)
                {
                    temp[0] = arr[j];
                    Array.Sort(temp);
                    min = temp[0];
                }
            }
            return temp;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 23, 12, 9, 30, 2, 50 };

            int[] result = Program.FindKMax(arr, 3);

            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

        }
    }
}
