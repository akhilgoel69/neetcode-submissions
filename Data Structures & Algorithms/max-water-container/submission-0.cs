public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxWater = Int32.MinValue;

        while (left < right) {
            var length = right - left;
            var height = Math.Min(heights[right], heights[left]);
            var area = length * height;
            maxWater = Math.Max(area, maxWater);

            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxWater;
    }
}
