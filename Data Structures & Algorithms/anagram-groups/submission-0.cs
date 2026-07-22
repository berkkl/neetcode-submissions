public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>(); 
        
        foreach(string word in strs){
            int[] counts = new int[26];
            foreach(char c in word){
                int index = c - 'a';
                counts[index]++;
            }
            string key = string.Join("#", counts);

            if(!groups.ContainsKey(key)){
                groups[key] = new List<string>();
            }
            groups[key].Add(word);
        }

        return new List<List<string>>(groups.Values);
    }
}
