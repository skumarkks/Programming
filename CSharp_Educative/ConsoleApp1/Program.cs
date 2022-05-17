using System;

namespace DutchNationalFlag
{
    class Program
    {
        public int[] DutchFlagSort(int[] arr)
        {
            // for edge cases
            if (arr == null) return null;
            if (arr.Length == 1) return arr;
             
            int low = 0;
            int high = arr.Length - 1;

            // all elements less than low are 0s
            // all elements greater than high are 2s
            for (int i = 0; i <= high;)
            {
                if(arr[i] == 0)
                {
                    //we want all i element of 0s at one side less than low
                    Swap(arr, i, low);
                    low++;
                    i++;
                }
                else if(arr[i] == 1)
                 {
                    // keep the 1s at the middle
                    i++;
                }
                else
                {
                    // we want all the i elements of 2s at one side greater than high
                    Swap(arr, i, high);
                    high--;
                }
            }
            return arr;
        }

        int[] DutchNationalFlagPartition(int[] arr)
        {
            int pivot = arr[arr.Length / 2];
            int equal = 0;
            int larger = arr.Length - 1;
            int smaller = 0;

            while(equal < larger)
            {
                if (arr[equal] < pivot)
                {
                    Swap(arr, smaller, equal);
                    smaller++;
                    equal++;
                }
                else if( arr[equal] == pivot)
                {
                    ++equal;
                }
                else if (arr[equal] > pivot)
                {
                    Swap(arr, equal, larger);
                    --larger;                    
                }
            }
            return arr;
        }

        // arrary value exchange by swaping
        void Swap(int[] arr, int i , int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        static void Main(string[] args)
        {
            //Test1 
            var prg = new Program();
            int[] arr = prg.DutchFlagSort(new int[] { 1, 0, 2, 1, 0 });
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine("Hello World!");

            //Test2
            arr = prg.DutchFlagSort(new int[] { 2, 2, 0, 1, 2, 0 });
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine("Hello World!");

            //Test3
            arr = prg.DutchFlagSort(new int[] { 1, 1, 0, 1, 0 });
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            //Test4 

            //var arr = prg.DutchNationalFlagPartition(new int[] { 1, 4, 2, 4, 2, 4, 1, 2, 4, 1, 2, 2, 2, 2, 4, 1, 4, 4, 4 });
            arr = prg.DutchNationalFlagPartition(new int[] { 2, 2, 0, 1, 2, 0 });
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
    }
}
