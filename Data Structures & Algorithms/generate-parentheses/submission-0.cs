public class Solution {
    public List<string> GenerateParenthesis(int n) {
        string current = string.Empty;
        List<string> res = new();
        Paran(n,current,0,0, res);

        return res;
    }

    public void Paran(int n, string current, int open, int closed, List<string> res) {

        if(current.Length == 2*n){
            res.Add(new string(current));
        }

        if(open<n){
            Paran(n,current+"(",open+1, closed, res);
        }

         if(closed<open){
            Paran(n,current+")",open, closed+1, res);
        }
        
    }
}
