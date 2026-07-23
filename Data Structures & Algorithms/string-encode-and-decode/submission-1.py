class Solution:

    def encode(self, strs: List[str]) -> str:
        encodedStringList = []

        for word in strs:
            encodedStringList.append(str(len(word)) + "#" + word)
            
        return "".join(encodedStringList)

    def decode(self, s: str) -> List[str]:
        result = []
        i = 0

        while i < len(s):
            j = i
            while s[j] != '#':
                j += 1
            
            word_length = int(s[i:j])
            start = j + 1
            end = start + word_length
            result.append(s[start:end])
            i = end
            
        return result