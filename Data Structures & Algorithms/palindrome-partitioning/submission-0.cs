public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> res = new();
        List<string> current = new();
        Partition(s, 0, current, res);
        return res;
    }

    public void Partition(string s, int index, List<string> current, List<List<string>> res) {
        if (index == s.Length) {
            res.Add(new List<string>(current));
            return;
        }

        for (int i = index; i < s.Length; i++) {
            var subStr = s.Substring(index, i - index + 1);
            if (!CheckPalindrome(subStr)) {
                continue;
            }
            current.Add(subStr);
            Partition(s, i + 1, current, res);
            current.RemoveAt(current.Count - 1);
        }
    }

    public bool CheckPalindrome(string str) {
        int start = 0;
        int end = str.Length - 1;
        var arr = str.ToArray();

        while (start < end) {
            if (arr[start] != arr[end]) {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
}
