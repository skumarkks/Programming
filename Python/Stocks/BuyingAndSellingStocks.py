#time complexity O(n) and space complexity O(1)
#leetcode 121
class Solution:
    def maxProfit(self, nums:list)->int:
        if len(nums) == 0:
            return 0

        left, right = 0, 1
        maxProfit = float("-inf")

        while right < len(nums):
            if nums[left] > nums[right]:
                left = right
            elif nums[left] < nums[right]:
                curProfit = nums[right]-nums[left]
                maxProfit = max(maxProfit, curProfit)
            right += 1
        return maxProfit if maxProfit != float("-inf") else 0

sol = Solution()
prices = [7,1,5,3,6,4]
print(sol.maxProfit(prices))
prices = [7,6,4,3,1]
print(sol.maxProfit(prices))






