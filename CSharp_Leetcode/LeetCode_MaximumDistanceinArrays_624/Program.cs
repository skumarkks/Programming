using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_MaximumDistanceinArrays_624
{
    class Program
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            int max = arrays[0][arrays[0].Count - 1];
            int min = arrays[0][0];
            int res = 0;

            for (int i = 1; i < arrays.Count; i++)
            {
                res = Math.Max(res,
                    Math.Max(Math.Abs(arrays[i][arrays[i].Count - 1] - min), Math.Abs(arrays[i][0] - max)));

                min = Math.Min(min, arrays[i][0]);
                max = Math.Max(max, arrays[i][arrays[i].Count - 1]);
            }
            return res;
        }
        static void Main(string[] args)
        {
            var prg = new Program();

            int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new [] {1,2,3};
            //jaggedArray[1] = new[] { 4,5 };
            //jaggedArray[2] = new[] { 1,2,3 };

            jaggedArray[0] = new [] {1,4};
            jaggedArray[1] = new[] { 0,5 };

            IList<IList<int>> arrays = jaggedArray;
            Console.WriteLine(prg.MaxDistance(arrays));

        }
    }
}
