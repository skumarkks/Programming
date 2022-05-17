using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletSum
{
	using System.Collections.Generic;

    public class TripletSum
    {
        public static List<int[]> FindTripletSum(int[] arr, int k)
        {
            if (arr.Length == 0) return null;

            List<int[]> resultList = new List<int[]>();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int pairSum = k - arr[i];
                
                TripletSum.FindPair(arr,i, pairSum, resultList);
                
                if (arr[i] == arr[i + 1]) i++;
            }
            return resultList; ;
        }


        public static void FindPair(int[] arr, int i, int k, List<int[]> resultList)
        {
            Dictionary<int, int> sumChecker = new Dictionary<int, int>();

            int start = i + 1;
            for (int end = start; end < arr.Length; end++)
            {
                int dif = k - arr[end];
                if (sumChecker.ContainsKey(dif))
                {
                    int[] resultTriplet = new int[3];
                    resultTriplet[0] = arr[i];
                    resultTriplet[1] = arr[end];
                    resultTriplet[2] = dif; ; 
                    resultList.Add(resultTriplet);
                }
                else
                {
                    if(!sumChecker.ContainsKey(arr[end]))
                        sumChecker.Add(arr[end], end);
                }

            }
        }

        public static void Main(string[] args)
        {
            int[] test1 = new int[] {-3, 0, 1, 2, -1, 1, -2};

            var result = TripletSum.FindTripletSum(test1, 0);

            int[] test2 = new int[] {-5,2,-1,-2,3 };
            result = TripletSum.FindTripletSum(test2, 0);
        }
    }

}
