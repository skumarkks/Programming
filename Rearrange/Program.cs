using System;

namespace Rearrange
{
    class Program
    {
        // rearrange arry with alternate high and low values
        public int[] Rearrange(int[] num)
        {
            for(int i =1; i < num.Length; i= i+2)
            {
                if (num[i - 1] > num[i])
                    Swap(num, i - 1, i);
                if (i + 1 < num.Length && num[i + 1] > num[i])
                    Swap(num, i + 1, i);
            }
            return num;
        }

        private void Swap(int[] num, int v, int i)
        {
            int temp = num[v];
            num[v] = num[i];
            num[i] = temp;
        }

        static void Main(string[] args)
        {
            int[] num = new int[] {1,2 };

            var prg = new Program();
            int[] result = prg.Rearrange(num);
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
