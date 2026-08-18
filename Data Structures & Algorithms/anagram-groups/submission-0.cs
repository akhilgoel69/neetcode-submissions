public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();
        List<List<string>> res = new();

        foreach (var str in strs) {
            var key = CreateKey(str);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }

        foreach(var keyItem in dict.Keys){
            res.Add(new List<string>(dict[keyItem]));
        }
        return res;
    }

    public string CreateKey(string str) {
        var charArr = str.ToArray();
        Array.Sort(charArr);
        string key = new string(charArr);
        return key;
    }
}
