public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> map = new();

        int[] res = new int[2];

        for(int i=0; i<nums.Length ; i++){

            var rem  = target -  nums[i];

            if(map.ContainsKey(rem)){
                res[0]=map[rem];
                res[1]=i;
                break;
            }
            else{
                map[nums[i]]=i;
            }
        }
        return res;
    }
}
