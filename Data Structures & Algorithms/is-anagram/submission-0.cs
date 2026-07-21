public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> char_s = new Dictionary<char, int>();
        Dictionary<char, int> char_t = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            char_s.TryGetValue(s[i], out int currentCountS);
            char_s[s[i]] = currentCountS + 1;

            char_t.TryGetValue(t[i], out int currentCountT);
            char_t[t[i]] = currentCountT + 1;
        }

        foreach (var entry in char_s){
            char_t.TryGetValue(entry.Key, out int t_val);
            if(entry.Value != t_val) return false;
        }

        return true;
    }
}
