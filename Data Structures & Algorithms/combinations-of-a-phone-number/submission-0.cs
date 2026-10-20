public class Solution {
    public List<string> LetterCombinations(string digits) {

        if(digits==string.Empty){
            return new List<string>();
        }
        List<string> res = new();
        string current = string.Empty;
        Dictionary<char, string> dict = new();
        dict['2'] = "abc";
        dict['3'] = "def";
        dict['4'] = "ghi";
        dict['5'] = "jkl";
        dict['6'] = "mno";
        dict['7'] = "pqrs";
        dict['8'] = "tuv";
        dict['9'] = "wxyz";
        Combi(digits, 0, current, res, dict);

        if(res.Count==0){
            return new List<string>();
        }
        return res;
    }

    public static void Combi(string digits, int index, string current, List<string> res,
                             Dictionary<char, string> dict) {
        if (index == digits.Length) {
            res.Add(current);
            return;
        }

        var digitStr = dict[digits[index]];

        for (int i = 0; i < digitStr.Length; i++) {
            Combi(digits, index + 1, current + digitStr[i], res, dict);
        }
    }
}
