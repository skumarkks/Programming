class Solution:

    def isAlphanumeric(self, ch) -> bool:
        return (ord('A') <= ord(ch) <= ord('Z') or
                ord('a') <= ord(ch) <= ord('z') or
                ord('0') <= ord(ch) <= ord('9')
               )

    def isPalindrome(self, s) -> bool:
        if len(s) == 0:
            return True

        l, r = 0, len(s) - 1
        while l <= r:
            while not self.isAlphanumeric(s[l]) and l < len(s) - 1:
                l += 1
            while not self.isAlphanumeric(s[r]) and r > 0:
                r -= 1
            if l <=r and  s[l].lower() != s[r].lower():
                return False
            l += 1
            r -= 1
        return True


sol = Solution()
str = "!12@"
x = sol.isPalindrome(str)
print(x)

