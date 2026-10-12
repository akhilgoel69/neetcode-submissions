public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new();
        List<int> current = new();
        int index = 0;
        GetSubsets(nums, index, current, res);
        return res;
    }

    public void GetSubsets(int[] nums, int start, List<int> current, List<List<int>> res) {
        res.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++) {
            current.Add(nums[i]);
            GetSubsets(nums, i + 1, current, res);
            current.RemoveAt(current.Count - 1);
        }
    }
}
