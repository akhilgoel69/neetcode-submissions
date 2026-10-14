public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = Int32.MinValue;
        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
            }
        }
        return maxProfit < 0 ? 0 : maxProfit;
    }
}
