from collections import defaultdict
class Solution:
    def groupAnagrams(self, strs: list) -> list:
        result = defaultdict(list)
        for s in strs:
            count = [0] * 26
            for c in s:
                count[ord(c) - ord("a")] = +1
            result[tuple(count)].append(s)
        return result.values()

sol = Solution()
strs =["eat", "tea", "tan", "ate", "nat", "bat"]
print(sol.groupAnagrams(strs))
