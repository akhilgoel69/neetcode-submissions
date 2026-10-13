public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> res = new();
        List<int> current = new();
        Array.Sort(nums);
        Subset(nums, 0, current, res);
        return res;
    }

    public void Subset(int[] nums, int start, List<int> current, List<List<int>> res) {
        res.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++) {
            if (i > start && nums[i] == nums[i - 1]) {
                continue;
            }

            current.Add(nums[i]);
            Subset(nums, i + 1, current, res);
            current.RemoveAt(current.Count - 1);
        }
    }
}
