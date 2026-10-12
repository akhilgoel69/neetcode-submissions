public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new();
        List<int> current = new();
        CombiSum(nums, 0, target, current, res);

        return res;
    }

    public void CombiSum(int[] nums, int start, int target, List<int> current,
                         List<List<int>> res) {
        if (target == 0) {
            res.Add(new List<int>(current));
            return;
        }

         
        

        for (int i = start; i < nums.Length; i++) {
if(nums[i]>target){
            continue;
        }
               

            current.Add(nums[i]);
            CombiSum(nums, i, target - nums[i], current, res);
            current.RemoveAt(current.Count - 1);
        }
    }
}
