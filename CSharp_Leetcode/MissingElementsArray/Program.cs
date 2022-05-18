using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingElementsArray
{
    class Program
    {
        public void MissingElements_Method1(int[] arr)
        {
            int diff = arr[0] - 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - i != diff)
                {
                    while (arr[i] - i > diff)
                    {
                        Console.WriteLine(diff+i);
                        diff++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new[] {6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19};
            var prg = new Program();
            prg.MissingElements_Method1(arr);
        }
    }
}
