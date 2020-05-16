using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class KthSmallestElement
    {

        public static int FindKthSmallestElement(int[] arr, int k)
        {
            if (arr.Length == 0 || arr.Length < k) return 0;

            var kList = new List<int>();

            for (int i = 0; i < k; i++)
            {
                kList.Add(arr[i]);
;           }

            var maxHeap = new MaxHeap(kList);

            for (int i = k; i < arr.Length; i++)
            {
                if(arr[i] < maxHeap.Peek() )
                {
                    maxHeap.Remove();
                    maxHeap.Insert(arr[i]);
                }
            }

            return maxHeap.Peek();
        }

        /*public static void Main(string[] args)
        {
            //var test1 = new int[] { 3, 1, 5, 12, 2, 11 };
            //var result = KLargestElement.FindKLargestElement_1(test1, 3);

            var test2 = new int[] { 1, 5, 12, 2, 11, 5 };
            var result2 = KthSmallestElement.FindKthSmallestElement(test2, 3);

            Console.WriteLine(result2);

        }*/
    }
}
