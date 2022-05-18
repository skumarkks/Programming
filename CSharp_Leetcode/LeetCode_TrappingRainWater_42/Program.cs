using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_TrappingRainWater_42
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0 || height.Length == 1)
                return 0;
            //start from the end and take difference between the each value 
            // if the difference is positive add up the difference upto index 1
            int volume = 0;
            for (int i = height.Length - 1; i >= 2; i--)
            {
                if (height[i] - height[i - 1] >= 1)
                {
                    volume += height[i] - height[i - 1];
                }
            }

            if (height[0] > 0 && height[1] > 0)
            {
                if (height[0] - height[1] > 0)
                    volume = volume + height[0] - height[1];
            }
            return volume;

        }
        public int Trap1(int[] height)
        {
            if (height.Length == 0 || height.Length == 1)
                return 0;
            if (height.Length == 2)
                return 0;
            // if a[i+1] is less then a[i] and a[i+2] then you can hold water 
            //how much water than you hold ? (find the  minimum of a{i} and a[i+2])- a[i+1]
            int vol = 0;
            for (int i = 0; i < height.Length - 1; i = i + 1)
            {
                if ((i + 2) <= height.Length - 1)
                {
                    if ((height[i + 1] < height[i]) &&
                        (height[i + 1] < height[i + 2]))
                    {
                        if (height[i] <= height[i + 2])
                        {
                            vol += height[i] - height[i + 1];
                        }
                        else
                        {
                            vol += height[i + 2] - height[i + 1];
                        }

                    }
                }
            }

            return vol;

        }

        public  int findMaxWater(int[] buildingHeights)
        {
            // use two pointer approach to find the maximum area
            int left = 0, right = buildingHeights.Length - 1;
            int maxArea = 0, currentArea = 0;

            while (left < right)
            {
                if (buildingHeights[left] < buildingHeights[right])
                {
                    currentArea = (right - left) * buildingHeights[left];
                    left++;
                }
                else
                {
                    currentArea = (right - left) * buildingHeights[right];
                    right--;
                }
                maxArea = Math.Max(maxArea, currentArea);
            }

            return maxArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            int[] heights = new int[] {2,1, 2};
            //int[] heights = new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            // int[] heights = new[] {4, 2, 3};
            //int val = sol.Trap1(heights);
            sol.findMaxWater(heights);

            //Console.WriteLine(val);
        }
    }
}
