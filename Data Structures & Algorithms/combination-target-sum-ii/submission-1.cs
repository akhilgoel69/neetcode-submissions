public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> res = new();
        List<int> current = new();
        Array.Sort(candidates);
        CombiSum(candidates, 0, target, current, res);

        return res;
    }

    public void CombiSum(int[] nums, int start, int target, List<int> current,
                         List<List<int>> res) {
        if (target == 0) {
            res.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < nums.Length; i++) {

            if (nums[i] > target) {
                continue;
            }

            if(i>start && nums[i]==nums[i-1]){
                continue;
            }

            current.Add(nums[i]);
            CombiSum(nums, i+1, target - nums[i], current, res);
            current.RemoveAt(current.Count - 1);
        }
    }
}
