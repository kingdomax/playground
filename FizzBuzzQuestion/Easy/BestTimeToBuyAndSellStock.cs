using System;

namespace FizzBuzzQuestion.Easy
{
    /*
        Input: [7,1,5,3,6,4]
        Output: 5
        Explanation:    Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
                        Not 7-1 = 6, as selling price needs to be larger than buying price.
    
        Input: [7,6,4,3,1]
        Output: 0
        Explanation:    In this case, no transaction is done, i.e. max profit = 0.
     */
    
    public static class BestTimeToBuyAndSellStock
    {
        /* 
            O(N)

            If we plot the numbers of the given array on a graph, we get:
            The points of interest are the peaks and valleys in the given graph. We need to find the largest peak following the smallest valley. 
            We can maintain two variables - minprice and maxprofit corresponding 
        */
        public static int MaxProfitN(int[] prices) 
        {
            int minprice = int.MaxValue;

            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++) 
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }
            return maxprofit;
        }

        // O(N^2) solution, brute force
        public static int MaxProfitN2(int[] prices) 
        {
            var maxProfitAmongAllDays = 0;
            
            // 1) traverse every day
            for (var day=0; day<prices.Length; day++)
            {
                // 2) find max profit for specific day
                var priceForThisDay = prices[day];
                var maxProfitForSpecificDay = 0;
                for (var otherDay=day+1; otherDay<prices.Length; otherDay++)
                {
                    CalculateProfit(ref maxProfitForSpecificDay, prices[otherDay], priceForThisDay);
                }
                
                // 3) compare all days profit which specific profit day
                CalculateProfit(ref maxProfitAmongAllDays, maxProfitForSpecificDay, 0);
            }
            
            return maxProfitAmongAllDays;
        }
        
        private static void CalculateProfit(ref int currentProfit, int priceSell, int priceBuy)
        {
            var newProfit = priceSell - priceBuy;
            
            // if loss use own profit value
            if (newProfit <= 0) { return; }
            
            // decide is it better for new profit
            currentProfit = (newProfit > currentProfit) ? newProfit : currentProfit;
        }
    }
}