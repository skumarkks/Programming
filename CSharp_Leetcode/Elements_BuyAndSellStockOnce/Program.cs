using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_BuyAndSellStockOnce
{
    /*class Program
    {
        /*public static int BuyAndSellStockOnce(int[] a)
        {
            var min = int.MaxValue;
            var profit = 0;

            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }

                var currentProfit = a[i] - min;
                profit = Math.Max(profit, currentProfit);
            }

            return profit;
        }

        public static int[] BuyAndSellStockTwice(int[] a)
        {
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int profit = 0;
            
            int[] first_but_sell_profit = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                min1 = Math.Min(min1, a[i]);
                profit = Math.Max(profit, a[i] - min1);
                first_but_sell_profit[i] = profit;
                
            }

            foreach (var i in first_but_sell_profit )
            {
                Console.WriteLine(i);
            }
            
            return first_but_sell_profit;
        }*/
        }*/

        static void Main(string[] args)
        {
            //int[] a = {310, 315, 275, 295, 260, 270, 290, 230, 255, 250};
            int[] a = {12, 11, 13, 9, 12, 8, 14, 13, 15};
            //int profit = Program.BuyAndSellStockOnce(a);
            //Console.WriteLine(profit);

            //int[] profits = Program.BuyAndSellStockTwice(a);
            //Console.WriteLine("profilts");

            //foreach (var i in profits)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
