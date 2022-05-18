using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_LeetCode_Merge
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return intervals;

            if (intervals.Length == 1)
                return intervals;

            // if x2 is between x1 and y1 then merge to x1 and y2.
            // else add x1 and x2 to the result set.
            ArrayList resultLt = new ArrayList();
            Array.Sort(intervals);

            for (int i = 0; i < intervals.Length; i++)
            {
                int currentx1 = intervals[i][0];
                int currenty1 = intervals[i][1];

                if (i + 1 == intervals.Length)
                {
                    resultLt.Add(currentx1);
                    resultLt.Add(currenty1);
                    break;
                }

                int nextcurrrentx2 = intervals[i + 1][0];
                int nextcurrrenty2 = intervals[i + 1][1];

                if ((currenty1 - nextcurrrentx2) >= 0)
                {
                    // set the new range in result
                    resultLt.Add(currentx1);
                    resultLt.Add(nextcurrrenty2);
                    i++;

                }
                //else if ((nextcurrrenty2 - currentx1) >= 0)
                //{
                //    // set the new range in result
                //    resultLt.Add(nextcurrrentx2);
                //    resultLt.Add(currenty1);
                //    i++;
                //}
                else
                {
                    // set the new range in result
                    resultLt.Add(currentx1);
                    resultLt.Add(currenty1);

                }
            }

            int ln = resultLt.Count / 2;

            int[][] result = new int[ln][];

            for (int i = 0, j = 0; j < ln; i = i + 2, j++)
            {
                result[j] = new int[2];
                result[j][0] = (int)resultLt[i];
                result[j][1] = (int)resultLt[i + 1];

            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[4][];
            
            for(int i = 0; i < intervals.Length; i++)
            {
                intervals[i] = new int[2];
            }

            
            intervals[0][0] = 1;
            intervals[0][1] = 3;

            intervals[1][0] = 2;
            intervals[1][1] = 6;

            intervals[2][0] = 8;
            intervals[2][1] = 10;

            intervals[3][0] = 15;
            intervals[3][1] = 18;

            var sol = new Solution();
            int[][] result = sol.Merge(intervals);

        }
    }
}
