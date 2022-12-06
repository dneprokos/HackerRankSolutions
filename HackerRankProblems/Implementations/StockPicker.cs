namespace HackerRankProblems.Implementations
{
    public class StockPicker
    {
        public static int FindMaximumProfit(int[] arr)
        {
            //var maxProfit = -1;
            //var buyPrice = 0;
            //var isIndexChanged = false;

            //for (var i = 0; i < arr.Length - 1; i++)
            //{
            //    var currentPrice = arr[i + 1];

            //    if (isIndexChanged)
            //    {
            //        buyPrice = arr[i];
            //    }

            //    if (currentPrice < buyPrice)
            //    {
            //        isIndexChanged = true;
            //    }
            //    else
            //    {
            //        var temp = currentPrice - buyPrice;
            //        if (temp > maxProfit)
            //            maxProfit = temp;

            //        isIndexChanged = false;
            //    }
            //}

            //return maxProfit;

            var maxProfit = -1;
            var buyPrice = 0;
            var isIndexChanged = true;

            // loop through list of stock prices once
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var sellPrice = arr[i + 1];

                if (isIndexChanged)
                    buyPrice = arr[i];

                if (sellPrice < buyPrice)
                    isIndexChanged = true;

                else
                {
                    var temp = sellPrice - buyPrice;
                    if (temp > maxProfit) { maxProfit = temp; }
                    isIndexChanged = false;
                }
            }

            return maxProfit;
        }
    }
}
