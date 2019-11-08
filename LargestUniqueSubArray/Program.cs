using System;
using System.Collections.Generic;

namespace LargestUniqueSubArray
{
    class Program
    {
        public List<int> FindLargestSubArray(int[] arr)
        {
            if (arr.Length == 0) return null;

            var charfreqMap = new Dictionary<int, int>();
            var result = new List<List<int>>();

            int windowsStart = 0;
            int maxCount = 0;
            for (int WindowsEnd = 0; WindowsEnd < arr.Length; WindowsEnd++)
            {
                if(!charfreqMap.ContainsKey(arr[WindowsEnd]))
                {
                    charfreqMap.Add(arr[WindowsEnd], 1);
                }
                else
                {
                    int i = windowsStart;
                    var res = new List<int>();
                    while (i < WindowsEnd)
                    {
                        res.Add(arr[i]);
                        i++;
                    }
                    result.Add(res);
                    maxCount = Math.Max(maxCount, WindowsEnd - windowsStart);
                    //charfreqMap[arr[windowsStart]] -= 1;
                    //if (charfreqMap[arr[windowsStart]] == 0)
                    charfreqMap.Remove(arr[windowsStart]);
                    windowsStart++;
                    WindowsEnd--;
                }
            }

            foreach (var item in result)
            {
                if(item.Count == maxCount)
                {
                    return item;
                }

            }
            return null;
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            var list = prg.FindLargestSubArray(new[] { 2, 0, 2, 1, 4, 3, 1, 0 });
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
