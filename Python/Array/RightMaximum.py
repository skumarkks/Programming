class Solution:
    def rightMaximum(self, nums:list)->list:
        if len(nums) == 0:
            return None

        rightMax = -1
        for i in range(len(nums)-1, -1,-1):
            currentMax = max(rightMax, nums[i])
            nums[i] = rightMax
            rightMax = currentMax
        return nums