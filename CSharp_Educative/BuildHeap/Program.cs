using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHeap
{
    public class Heap
    {
        public static int Parent(int i)
        {
            return (i - 1) / 2;
        }
        public static int Left(int i)
        {
            return 2*i + 1;
        }

        public static int Right(int i)
        {
            return 2*i + 2;
        }

        public static int[] BuildHeap(int[] array)
        {
            int len = array.Length;
            for (int i = (len/2)-1; i >= 0; i--)
            {
                MaxHeapify(array, i,len);
            }
            return array;
        }

        public static void MaxHeapify(int[] array, int i, int heapSize)
        {
            int left = Left(i);
            int right = Right(i);

            int largestIdx = -1;
            if (left < heapSize && array[left] > array[i])
                largestIdx = left;
            else
                largestIdx = i;
            if (right < heapSize && array[right] > array[largestIdx])
                largestIdx = right;

            if (largestIdx != i)
            {
                swap(array, i, largestIdx);
                MaxHeapify(array,largestIdx, heapSize);
            }

        }
        public static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static int[] HeapSort(int[] array)
        {
            if (array.Length == 1) return array;

            array = BuildHeap(array);

            //if (array.Length == 2) return array;

            int len = array.Length-1;
            for (int i = len; i >= 1; i--)
            {
                swap(array, 0, i);
                int heapSize = i;
                MaxHeapify(array, 0, heapSize);
            }
            return array;
        }


        public static void Main(string[] args)
        {
            //int[] array = new int[] { 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 };
            //int[] array = new int[] { 4,1,3,2,16,9,10,14,8,7 };
            //int[] heap = Heap.BuildHeap(array);
            int[] array = new int[] { 1, 2,3 };
            int[] heap = Heap.HeapSort(array);

            foreach (var item in heap)
            {
                Console.Write("{0} ", item);
            }
        }

    }

}
