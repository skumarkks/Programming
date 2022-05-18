class Solution:
    def maxSubsetSumNoAdjacent(self,array):
        if not len(array):
            return 0
        elif len(array) == 1:
            return array[0]
        maxsum = array[:]
        maxsum[1] = max(array[0], array[1])
        for idx in range(2, len(array)):
            maxsum[idx] = max(array[idx - 1], maxsum[idx - 2] + array[idx])
        return maxsum[-1]


sol = Solution()
nums = [75, 105, 120, 75, 90, 135]
result = sol.maxSubsetSumNoAdjacent(nums)
print(result)