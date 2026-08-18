public class Solution {
    public bool IsPalindrome(string s) {

        int p1= 0;
        int p2 = s.Length-1;

        while(p1<=p2){

            while(p1<s.Length && !char.IsLetterOrDigit(s[p1])){
                p1++;
            }

            if(p1>s.Length-1){

                break;
                   
                }

            var left = s[p1];
            

            while(p2>=0 && !char.IsLetterOrDigit(s[p2])){
                p2--;
            }

            if(p2<0){
                    break;
                }
            var right = s[p2];

            if(p1<=p2){

                if(char.ToLower(left) != char.ToLower(right))
                {
                    return false;
                }
                else{
                        p1++;
                        p2--;
                }
            }
        }

        return true;

        
    }
}
