using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class KFrequentNumbers
    {

        public static List<int> FindKFrequentNumbers(int[] arr, int k)
        {
            var frequencyMap = new Dictionary<int, int>();
            List<int> nums = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!frequencyMap.ContainsKey(arr[i]))
                {
                    nums.Add(arr[i]);
                    frequencyMap.Add(arr[i], 1);
                }
                else
                    frequencyMap[arr[i]] += 1;

            }

            var minHeap = new MinHeap(nums.ToList());
            while(minHeap.heapSize > k)
            {
                minHeap.Remove();
            }

            return null;
        }

        /*public static void Main(string[] args)
        {
            int[] test1 = new int[] { 1, 3, 5, 12, 11, 12, 11 };

            KFrequentNumbers.FindKFrequentNumbers(test1,2);

        }*/

    }
}
