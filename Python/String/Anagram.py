class Solution:
    def isAnagram(self, s:string, t:string) -> bool:
        if len(s) != len(t):
            return False
        hashmap = {}

        for val in s:
            if val not in hashmap:
                hashmap[val] = 0
            hashmap[val] += 1

        for val in t:
            if val in hashmap:
                hashmap[val] -= 1
                if hashmap[val] == 0:
                    del hashmap[val]
            else:
                return False
        return True if len(hashmap) == 0 else False


sol = Solution
s = "anagram"
t = "nagaram"
print(sol.isAnagram(s,t))