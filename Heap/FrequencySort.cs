using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrentPriorityQueue;

namespace Heap
{
    class FrequencySort
    {
        public static string FindFrequencySort(string input)
        {
            if (input.Length == 0) return null;

            var frequencyMap = new Dictionary<char, int>();
            var list = new List<char>();

            var maxHeap = new ConcurrentPriorityQueue<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(!frequencyMap.ContainsKey(input[i]))
                {
                    list.Add(input[i]);
                    frequencyMap.Add(input[i], 1);
                    
                }
                else
                {
                    frequencyMap[input[i]] += 1;
                }
            }

            foreach(var item in frequencyMap)
            {
                maxHeap.Enqueue(item.Key, item.Value);
            }

            var sb = new StringBuilder();

            while(maxHeap.Count != 0)
            {
                char ch = maxHeap.Dequeue();
                int j = frequencyMap[ch];
                for (int i = 0; i < j; i++)
                {
                    sb.Append(ch);
                }
                
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            string test1 = "Programming";

            string result = FrequencySort.FindFrequencySort(test1);

        }

    }
}
