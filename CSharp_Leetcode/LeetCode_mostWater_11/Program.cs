using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_mostWater_11
{
    class Program
    {
        /*public static int MaxArea(int[] height)
        {
            if (height.Length == 1)
                return 0;

            int maxArea = 0;
            for (int j = height.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (height[j] <= height[i])
                    {
                       int currentArea = height[j] * (j - i);
                        if (maxArea < currentArea)
                        {
                            maxArea = currentArea;
                        }
                    }
                    else if (height[i] <= height[j])
                    {
                        int currentArea = height[i] * (j - i);
                        if (maxArea < currentArea)
                        {
                            maxArea = currentArea;
                        }

                    }
                }
            }        

            return maxArea;
        }*/

        public static int MaxArea(int[] height)
        {

            if (height.Length == 0 || height.Length == 1) return 0;

            int maxArea = 0;
            int currentArea = 0;

            for (int i = height.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (height[j] <= height[i])
                    {
                        currentArea = height[j] * (j - i);
                    }
                    else if (height[i] <= height[j])
                    {
                        currentArea = height[i] * (j - i);
                    }
                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
            return maxArea;
        }
        static void Main(string[] args)
        {
            int[] input = new[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            int area = Program.MaxArea(input);
            Console.WriteLine(area);
        }
    }
}
