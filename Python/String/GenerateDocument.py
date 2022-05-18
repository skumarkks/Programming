class Solution:
    def generateDocument(self, characters, document):
        # Write your code here.
        if len(characters) == 0 or len(document) == 0:
            return False

        charmap = {}
        for ch in characters:
            if ch not in charmap:
                charmap[ch] = 0
            charmap[ch] += 1

        for ch in document:
            if ch not in charmap:
                return False
            elif ch in charmap:
                charmap[ch] -= 1
                if charmap[ch] == 0:
                    charmap.pop(ch)
        return True


sol = Solution()
x = sol.generateDocument("abcabc", "accbba")
print(x)

x = sol.generateDocument("abcabc", "xaccbba")
print(x)