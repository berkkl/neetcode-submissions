class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        count_a = {}
        count_b = {}
        for i in range(len(s)):
            ch_a = s[i]
            ch_b = t[i]
            if ch_a in count_a:
                count_a[ch_a] += 1
            else:
                count_a[ch_a] = 1
            
            if ch_b in count_b:
                count_b[ch_b] += 1
            else:
                count_b[ch_b] = 1

        for key, value in count_a.items():
            if value != count_b.get(key, 0):
                return False
        return True