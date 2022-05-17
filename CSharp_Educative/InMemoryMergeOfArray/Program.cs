using System;

namespace InMemoryMergeOfArray
{
    class Program
    {
        public void MergeInMemoryOfArray(int[] n1, int[] n2)
        {
            int i = 0;
            int j = 0;

            while(i <= n1.Length-2 && j <= n2.Length-1)
            {
                if (n1[i] <= n2[j])
                {
                    swap(n1, n2, i + 1, j);
                    //Array.Sort(n2);

                    for (int k = 0; k < n2.Length-1; k++)
                    {
                        if (n2[k] > n2[k + 1])
                        {
                            int temp = n2[k];
                            n2[k] = n2[k + 1];
                            n2[k + 1] = temp;
                            
                        }
                    }

                    i++;
                }
                else if (n1[i] > n2[j])
                {
                    swap(n1, n2, i, j);
                    //Array.Sort(n2);
                    for (int k = 0; k < n2.Length - 1; k++)
                    {
                        if (n2[k] > n2[k + 1])
                        {
                            int temp = n2[k];
                            n2[k] = n2[k + 1];
                            n2[k + 1] = temp;
                            
                        }
                    }
                }
            }
        }

        private void swap(int[] n1, int[] n2, int i, int j)
        {
            int temp = n1[i];
            n1[i] = n2[j];
            n2[j] = temp;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            int[] n1 = new int[] { 4, 6, 7, 8, 10 };
            int[] n2 = new int[] { 2, 3, 9 };
            
            prg.MergeInMemoryOfArray(n1, n2);

            foreach (var item in n1)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();
            foreach (var item in n2)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();
            
            n1 = new int[] { 2, 4, 7, 8, 10 };
            n2 = new int[] { 2, 3, 9 };

            prg.MergeInMemoryOfArray(n1, n2);

            foreach (var item in n1)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();
            foreach (var item in n2)
            {
                Console.Write("{0} ", item);

            }

            Console.WriteLine();

            prg = new Program();
            n1 = new int[] { 1, 4, 7, 8, 10 };
            n2 = new int[] { 2, 3, 9 };

            prg.MergeInMemoryOfArray(n1, n2);

            foreach (var item in n1)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();
            foreach (var item in n2)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();

            Console.WriteLine("Hello World!");
        }
    }
}
