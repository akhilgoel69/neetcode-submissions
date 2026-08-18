public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> res = new();
        HashSet<(int , int, int)> hs = new();
        Array.Sort(nums);
        for(int i=0; i<nums.Length-2; i++){
            int left = i+1;
            int right = nums.Length-1;

            while(left<right){

                int sum = nums[i]+nums[left]+nums[right];
                if(sum==0){
                    var lis = new List<int>(){nums[i],nums[left],nums[right]};
                    var hsKey = (nums[i], nums[left],nums[right]); 
                    if(hs.Add(hsKey)){
                        res.Add(lis);
                    }
                    left++;
                    right--;
                }
                else if(sum>0){
                    right--;
                }
                else{
                    left++;
                }
            }
        }
        return res;
    }
}
