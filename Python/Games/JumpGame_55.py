# Leetcode 55
#
class Solution:
    def jumpGame(self, nums:list)->bool:
        goal = len(nums)-1

        for i in range(len(nums)-1, -1,-1):
            if i+ nums[i] >= goal:
                goal = i
        return True if goal == 0 else False


sol = Solution()
#nums = [2, 3, 1, 1, 4]
#nums = [1,0]
nums = [1,2]
print(sol.jumpGame(nums))