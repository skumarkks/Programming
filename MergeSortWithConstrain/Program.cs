using System;

namespace MergeSortWithConstrain
{
    class Program
    {
        public void Rearrange(int[] x)
        {
            int i = -1;
            int j = -1;

            do
            {
                do
                {
                    j++;
                    if (j >= x.Length) break;
                    if (x[j] > 0 ) break;                    
                } while (j < x.Length);

                do
                {
                    i++;
                    if (i >= x.Length) break;
                    if (x[i] == 0) break;
                } while (i < x.Length);

                if (j < x.Length && i < x.Length)
                    swap(x, i, j);

            } while (j < x.Length && i < x.Length);

           
        }

        int[] MergeSort(int[] x, int[] y)
        {

            Rearrange(x);

            int i = 0;
            int j = 0;

            while(i < x.Length && j < y.Length)
            {
                if(x[i] < y [j])
                {
                    i++;
                }
                else if (x[i] > y[j])
                {
                    swap(x, y, i, j);
                }

                if (x[i] == 0) break;
            }

            while (i < x.Length && j < y.Length)
            {
                x[i] = y[j];
                i++;
                j++;
            }
            return x;

        }

        private void swap(int[] x,int[] y, int i, int j)
        {
            int temp = x[i];
            x[i] = y[j];
            y[j] = temp;
        }
        private void swap(int[] x, int i, int j)
        {
            int temp = x[i];
            x[i] = x[j];
            x[j] = temp;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            int[] x = new int[] { 0, 2, 0, 3, 0, 5, 6, 0, 0 };
            int[] y = new int[] { 1, 8, 9, 10, 15 };
            int[] result = prg.MergeSort(x,y);
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
