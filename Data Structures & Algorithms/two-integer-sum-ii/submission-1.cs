public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        int[] res = new int[2];

        while (left < right) {
            var sum = numbers[left] + numbers[right];
            if (sum == target) {
                res[0] = left + 1;
                res[1] = right + 1;
                break;
            } else if (sum<target){
                left++;
            }
            else{
                right--;
            }
        }
        return res;
    }
}
