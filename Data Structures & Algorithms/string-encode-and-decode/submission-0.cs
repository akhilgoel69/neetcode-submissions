public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach (var str in strs) {
            var len = str.Length;

            sb.Append(len);
            sb.Append("#");
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new();
        int i = 0;

        while (i < s.Length) {
            var dlimiterIndex = s.IndexOf('#', i);

            var strLen = int.Parse(s.Substring(i, dlimiterIndex - i));

            var word = s.Substring(dlimiterIndex + 1, strLen);

            res.Add(word);

            i = dlimiterIndex + 1 + strLen;
        }

        return res;
    }
}
