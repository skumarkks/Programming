using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_ArrayIntersection_349
{
    class Program
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> outList = new List<int>();
           

            // convert the num1 into a list
            var list = new List<int>();

            foreach (int n in nums1)
            {
                list.Add(n);
            }

            foreach (int n in nums2)
            {
                int i = -1;
                i = list.IndexOf(n);
                if (i >= 0)
                {
                    outList.Add(n);
                }

                while (i >= 0)
                {
                    list.RemoveAt(i);
                    i = list.IndexOf(n);
                }
                
            }

            return outList.ToArray(); 
        }

        static void Main(string[] args)
        {
        }
    }
}
