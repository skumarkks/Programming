import sys

class Solution:
    def minWindow(self, s, t):
        str1 = s
        pattern = t

        if len(str1) == 0 or len(pattern) == 0:
            return ""

        charfrequency = {}

        for ch in pattern:
            if ch not in charfrequency:
                charfrequency[ch] = 0
            charfrequency[ch] += 1

        startidx, endidx = 0, 0
        minlength = sys.maxsize
        substrstartidx = 0
        matched = 0

        while endidx < len(str1):
            rightch = str1[endidx]
            if rightch in charfrequency:
               charfrequency[rightch] -= 1
               if charfrequency[rightch] >= 0:
                matched += 1

            while matched == len(pattern):
                currentlength = endidx - startidx +1
                if minlength > currentlength:
                    minlength = currentlength
                    substrstartidx = startidx

                leftch = str1[startidx]
                startidx += 1
                if leftch in charfrequency:
                    if charfrequency[leftch] == 0:
                        matched -= 1
                charfrequency[leftch] += 1
            endidx += 1

        if minlength < len(str1):
            return str1[substrstartidx:substrstartidx + minlength]
        else:
            return ""


sol = Solution()
str1 = "ADOBECODEBANC"
pattern = "ABC"
str2 = sol.minWindow(str1, pattern)
print(str2)
