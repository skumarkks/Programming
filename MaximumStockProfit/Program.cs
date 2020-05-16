using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumStockProfit
{
    class Program
    {
        public static int[] FindMaximumProfit(int[] nums)
        {
            if (nums.Length == 0) return null;
            int maxProfit = Int32.MinValue;
            int[] stocks = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentBuy = nums[i];

                for (int j = i+1; j < nums.Length; j++)
                {
                    int currentSell = nums[j];
                    int currentProfit = currentSell - currentBuy;

                    if(currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                        stocks[0] = currentBuy;
                        stocks[1] = currentSell;
                    }
                }

            }
            return stocks;

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int[] result = Program.FindMaximumProfit(nums);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
