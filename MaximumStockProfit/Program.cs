using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumStockProfit
{
    class Program
    {
        public static  int FindMaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;



            int minValue = Int32.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue) 
                    minValue = prices[i];
                
                if(prices[i]-minValue > maxProfit)
                {
                    maxProfit = prices[i] - minValue;
                }

            }

            return maxProfit;
        }

        public static int FindMaximumProfit(int[] nums)
        {
            if (nums.Length == 0) return 0;
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
            return stocks[1] - stocks[0];

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int result = Program.FindMaximumProfit(nums);
            Console.WriteLine(result);

            result = Program.FindMaxProfit(nums);
            Console.WriteLine(result);
        }
    }
}
