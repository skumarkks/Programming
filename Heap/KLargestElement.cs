using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class KLargestElement
    {
        public static List<int> FindKLargestElement(int[] arr, int k)
        {
            if (arr.Length == 0) return null;
            if(arr.Length < k ) return null;

            var heapList = new List<int>();
            
            for(int i = 0; i < k; i++)
            {
                heapList.Add(arr[i]);
            }

            var minHeap = new MinHeap(heapList);

            for(int j = k; j < arr.Length; j++)
            {
                if(minHeap.Peek() < arr[j])
                {
                    minHeap.Remove();
                    minHeap.Insert(arr[j]);
                }
            }

            int size = minHeap.heapSize;
            var result = new List<int>();
            for(int i = 0; i < size; i++)
            {
                result.Add(minHeap.Remove());
            }
            return result;
        }

        public static List<int> FindKLargestElement_1(int[] arr, int k)
        {
            var list = arr.ToList<int>();

            var minHeap = new MinHeap(list);

            for (int i = 0; i < arr.Length-k ; i++)
            {
                minHeap.Remove();
            }
            int size = minHeap.heapSize;
            var result = new List<int>();
            for (int i = 0; i < size; i++)
            {
                result.Add(minHeap.Remove());
            }
            return result; ;

        }
        /*public static void Main(string[] args)
        {
            var test1 = new int[] {3,1,5,12,2,11 };
            var result = KLargestElement.FindKLargestElement_1(test1,3);

        }*/
    }
}
