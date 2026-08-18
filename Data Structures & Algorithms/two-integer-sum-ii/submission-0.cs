public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int p1=0;
        int p2= numbers.Length-1;

        int[] res = new int[2];

        while(p1<p2){
            
            var left = numbers[p1];
            var right = numbers[p2];

            if((left+right)==target){
                res[0]=p1+1;
                res[1]= p2+1;
                break;
            }
            else if((left+right)<target){
                    p1++;
            }
            else{
                p2--;
            }
        }
        return res;
    }
}
