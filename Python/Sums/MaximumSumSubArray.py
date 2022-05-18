#leetcode -53
class Solution:
    def maxsumsubarray(self, nums: list) -> list:
        currentSum = nums[0]
        maxSum = nums[0]
        maxsumIdx = [0, 0]
        prevMax = 0

        for i in range(1, len(nums)):
            currentSum += nums[i]
            if currentSum == 0 or currentSum < nums[i]:
                currentSum = nums[i]
                maxsumIdx[0] = i
            if maxSum < currentSum:
                prevMax = maxSum
                maxSum = currentSum
                maxsumIdx[1] = i
        return maxsumIdx

    def maxsumSubArrayKadanesAlgo(self, nums:list) -> int:
        maxSumEndingHere = nums[0]
        maxSumSoFar = nums[0]

        for i in range(1, len(nums)):
            maxSumEndingHere = max(maxSumEndingHere + nums[i], nums[i])
            maxSumSoFar = max(maxSumSoFar, maxSumEndingHere)

        return maxSumSoFar


sol = Solution()
nums = [-2, 2, -3, 4, -1, 2, 1, -5, 4]
x = sol.maxsumsubarray(nums)
print(x)
maxSum = sol.maxsumSubArrayKadanesAlgo(nums)
print(maxSum)




