class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}
        for word in strs:
            groups = [0] *26
            for ch in word:
                groups[ord(ch) - ord('a')] += 1
            
            key = tuple(groups)
            if key in anagrams:
                anagrams[key].append(word)
            else:
                anagrams[key] = [word]
        
        return list(anagrams.values())