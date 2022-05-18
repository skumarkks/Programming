class Solution:
    def SearchInsert(self, nums: list, target : int) -> int:
        l, r = 0, len(nums) - 1

        while l <= r and l > -1:
            mid = int((l + r)/2)
            if target == nums[mid]:
                return mid
            elif target > nums[mid]:
                l = mid+1
            elif target < nums[mid]:
                r = mid-1
        return l

sol = Solution()
nums = [1]
target = 2
x = sol.SearchInsert(nums, target)
print(x)
