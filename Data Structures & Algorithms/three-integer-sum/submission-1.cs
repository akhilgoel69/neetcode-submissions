public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        HashSet<string> hash = new();
        List<List<int>> res = new();

        for (int i = 0; i < nums.Length; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                var key = nums[i].ToString() + nums[left].ToString() + nums[right].ToString();
                    if(!hash.Contains(key)){
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        hash.Add(key);

                    }
                        
                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;

                } else {
                    right--;
                }
            }
        }
        return res;
    }
}
