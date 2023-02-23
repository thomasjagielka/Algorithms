using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    // TODO:
    // Fix Time Limit Exceeded.

    internal class _121BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int[] point = new int[2];
            int bestBuyPoint = -1;
            int bestSellPoint = -1;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i; j < prices.Length; j++)
                {
                    if (bestBuyPoint == -1 || bestSellPoint == -1 ||
                        prices[j] - prices[i] > prices[bestSellPoint] - prices[bestBuyPoint])
                    {
                        bestBuyPoint = i;
                        bestSellPoint = j;
                    }
                }
            }

            return prices[bestSellPoint] - prices[bestBuyPoint];
        }
    }
}
