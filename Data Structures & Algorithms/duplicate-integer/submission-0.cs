public class Solution {
    public bool hasDuplicate(int[] nums) {

        bool res = false;
        HashSet<int> hash = new();

        foreach(var item in nums){
            if(!hash.Contains(item)){
                hash.Add(item);
            }
            else{
                res = true;
                break;

            }
            
        }

        return res;
        
    }
}