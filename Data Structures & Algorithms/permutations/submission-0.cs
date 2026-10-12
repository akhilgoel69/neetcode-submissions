public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();
        List<int> current = new();
        HashSet<int> visited = new();
        Perma(nums, visited, current, res);
        return res;
    }

    public void Perma(int[] nums, HashSet<int> visited, List<int> current, List<List<int>> res) {
        if (current.Count == nums.Length) {
            res.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (visited.Contains(nums[i])) {
                continue;
            }
            current.Add(nums[i]);
            visited.Add(nums[i]);
            
            Perma(nums, visited, current, res);

            current.RemoveAt(current.Count - 1);
            visited.Remove(nums[i]);
        }
    }
}
