#Time Complexity O(n) and space complexity O(1)
class Solution:
    def removeDuplicate(self, nums: list) -> int:
        if len(nums) == 0 or len(nums) == 1:
            return len(nums)
        left, right = 0, 1
        while right < len(nums):
            while right < len(nums) and nums[left] == nums[right]:
                right += 1
                if right < len(nums) and nums[left] != nums[right]:
                    left += 1
                    nums[left] = nums[right]
            left += 1
            right += 1
        return left

sol = Solution()
nums = [2,3,3,3,6,9,9]
print(sol.removeDuplicate(nums))

nums = [2, 2, 2, 11]
print(sol.removeDuplicate(nums))
