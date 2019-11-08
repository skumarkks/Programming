using System;

namespace SortArray
{
    class Program
    {
        public int[] SortBinaryArray(int[] arr)
        {
            if (arr.Length == 0) return null;
            if (arr.Length == 1) return arr;

            int i = 0;
            int j = arr.Length - 1;

            while(i < j)
            {
                while (arr[i] == 0) i++;
                while (arr[j] == 1) j--;
                if(i < j)
                    swapi(arr, i, j);
            }
            return arr;
        }

        private void swapi(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp; 
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            var result = prg.SortBinaryArray(new int[] { 0, 0, 1, 0, 1, 1, 0, 1, 0, 0 });
            foreach (var item in result)
            {
                Console.Write("{0},", item);
            }
            
        }
    }
}
