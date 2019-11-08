using System;
using System.Collections.Generic;

namespace TripleSumNew
{
    public class TripleSum
    {
        // Naive recursive function to check if triplet exists in array
        // with given sum
        bool tripletExists(int[] arr, int n, int sum, int count)
        {
            // if triplet has desired sum, return true
            if (count == 3 && sum == 0)
                return true;

            // return false if sum is not possible with current configuration
            if (count == 3 || n == 0 || sum < 0)
                return false;

            // recur with
            // 1. including current element
            // 2. excluding current element
            return tripletExists(arr, n - 1, sum - arr[n - 1], count + 1) ||
                    tripletExists(arr, n - 1, sum, count);
        }

        public List<List<int>> SearchTripletWithOutSorting(int[] arr, int target)
        {
            if (arr.Length == 0 || arr.Length < 3) return null;
            
            var arrayHash = new Dictionary<int, int>();
            var result = new List<List<int>>();


            for(int i = 0; i < arr.Length; i++)
            {
                arrayHash.Add(arr[i], i);
            }

            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = i+1; j  < arr.Length-1; j++)
                {
                    int findNumber = target - arr[i] - arr[j];

                    if(arrayHash.ContainsKey(findNumber))
                    {
                        if (arrayHash[findNumber] > i && arrayHash[findNumber] > j)
                        {
                            result.Add(new List<int>() { arr[i], arr[j], findNumber });
                        }
                    }
                }
            }
            return result;
        }

        public List<List<int>> SearchTriplet(int[] arr, int target)
        {
            if (arr.Length == 0 || arr.Length < 3) return null;

            Array.Sort(arr);
            var result = new List<List<int>>();

            for(int i = 0; i < arr.Length-2;i++)
            {
                if(arr[i] >= target)
                {
                    i++;
                }

                SearchPairs(arr, i, i + 1, target - arr[i], result);

                if(arr[i] == arr[i+1]) i++;
            }
            return result;
        }

        private void SearchPairs(int[] arr,int i,  int left, int target, List<List<int>> result)
        {
            int right = arr.Length - 1;

            while(left < right)
            {
                int sum = arr[left] + arr[right];

                if(sum == target)
                {
                    result.Add(new List<int> { arr[i], arr[left], arr[right] });
                    //left++
                    if (arr[right] == arr[right - 1])
                        right--;
                    right--;
                }
                else if(sum > target)
                {
                    if (arr[right] == arr[right - 1])
                        right--;
                    right--;
                }
                else
                {
                    if (arr[left] == arr[left + 1])
                        left++;
                    left++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new TripleSum();
            var result = prg.SearchTriplet(new int[] { 2, 7, 4, 0, 9, 5, 1, 3 }, 6);

            foreach (var r in result)
            {
                foreach (var i in r)
                {
                    Console.Write(i);
                }
                Console.WriteLine();               
            }

            Console.WriteLine("***");
            result = prg.SearchTripletWithOutSorting(new int[] { 2, 7, 4, 0, 9, 5, 1, 3 }, 6);

            foreach (var r in result)
            {
                foreach (var i in r)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
