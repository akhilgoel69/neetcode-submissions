public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> freq = new();



        foreach (var item in s) {
            if (!freq.ContainsKey(item)) {
                freq[item] = 0;
            }
            freq[item]++;
        }

        if (freq.Count > 0) {
            foreach (var item in t) {
                if (freq.ContainsKey(item)) {
                    freq[item]--;

                    if (freq[item] == 0) {
                        freq.Remove(item);
                    }
                }
            }
        }

        if (freq.Count == 0) {
            return true;
        }
        return false;
    }
}
