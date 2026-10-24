public class Solution {
    public bool CheckValidString(string s) {
        int minOpen = 0;
        int maxOpen = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                minOpen++;
                maxOpen++;
            } else if (s[i] == ')') {
                minOpen--;
                maxOpen--;
            } else {
                minOpen--;
                maxOpen++;
            }
            if(maxOpen<0){
                return false;
            }
            minOpen  = minOpen<0?0:minOpen;
        }

        return minOpen==0;
    }
}
