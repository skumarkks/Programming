class Solution:
    def FirstNonRepeatingCharacter(self, string:str)->int:
        if len(string) == 0:
            return -1
        charFreqMap = {}

        for ch in string:
            if ch not in charFreqMap:
                charFreqMap[ch] = 0
            charFreqMap[ch] += 1

        for idx in range(len(string)):
            ch = string[idx]
            if charFreqMap[ch] == 1:
                return idx
        return -1


sol = Solution()
string = "aabbc"
idx = sol.FirstNonRepeatingCharacter(string)
print(idx)

string = "aa"
idx = sol.FirstNonRepeatingCharacter(string)
print(idx)

string = "baa"
idx = sol.FirstNonRepeatingCharacter(string)
print(idx)