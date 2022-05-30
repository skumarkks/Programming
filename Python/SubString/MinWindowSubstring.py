#Leetcode 76
class Solution:
    def MinWindowSubstring(self, s:str, t:str)->str:
        tMap = {}
        for ch in t:
            if ch not in tMap:
                tMap[ch] = 0
            tMap[ch] += 1

        start, end = 0,0
        minLength = float("inf")
        matched = 0
        startSubIdx = 0

        for end in range(len(s)):
            rightCh = s[end]
            if rightCh in tMap:
                tMap[rightCh] -= 1
                if tMap[rightCh] >= 0:
                    matched += 1

            while matched == len(t):
                currentLength = end-start+1
                if currentLength < minLength:
                    startSubIdx = start
                    minLength = min(minLength, currentLength)
                leftCh = s[start]
                start += 1

                if leftCh in tMap:
                    if tMap[leftCh] == 0:
                        matched -= 1
                    tMap[leftCh] += 1

        return s[startSubIdx:startSubIdx+minLength] if minLength >= len(t) else ""

sol = Solution()
print(sol.MinWindowSubstring("ADOBECODEBANC", "ABC"))









