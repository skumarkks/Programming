using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekForGreek_hasArrayTwoCandidates
{
    class Program
    {
        // For the given array and a value k is there exist an pair having the sum equal to the value k
        public static  int[] HasArrayPairExist(int[] arr, int k)
        {
            Array.Sort(arr);

            int l = 0, r = arr.Length - 1;

            while (l < r)
            {
                if (arr[l] + arr[r] == k)
                {
                    int[] result = new[] {arr[l], arr[r]};
                    return result;
                }
                else if (arr[l] + arr[r] > k)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return null;
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 4, 45, 6, 10, -8};
            int k = 16;
            
           var result = Program.HasArrayPairExist(arr, k);
            foreach (var i in result)
            {
                Console.WriteLine(i);   
            }
            

        }
    }
}
