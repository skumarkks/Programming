# reverse a sentense "This is sky" --> "sky is This"
# reverse a sngle word sentence "sky" --> sky

class Solution:
    def reverseWords(self, s):
        start, end = 0, 0
        while end <= len(s) -1:
            if s[end] == " " or end == len(s) -1:
                if end != len(s) -1:
                    self.wordreverse(s, start, end-1)
                    start = end+1
                else:
                    self.wordreverse(s, start, end)
            end += 1

        self.wordreverse(s, 0, len(s)-1)

    def wordreverse(self, s, left, right):
        while left <= right:
            self.swap(s, left, right)
            left += 1
            right -= 1

    def swap(self, s, start, end):
        temp = s[start]
        s[start] = s[end]
        s[end] = temp

sol = Solution()
l = ["t", "h", "i", "s", " ", "i", "s", " ", "k", "e", "y"]
sol.reverseWords(l)
print(l)

l = ["t", "h", "i", "s"]
sol.reverseWords(l)
print(l)


l = ["t"]
sol.reverseWords(l)
print(l)

l = ["t","i"]
sol.reverseWords(l)
print(l)

l = ["h", "e", "l", "l", "o", " ", "c", "i", "t", "y"]
sol.reverseWords(l)
print(l)

