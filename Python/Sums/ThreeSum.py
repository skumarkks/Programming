#leetcode 15
#Time complexity O(nlogn)+O(n^2) ~ O(n^2) and space complexity O(1)
class Solution:
    def threeSum(self, nums:list, target:int) -> list:
        if not len(nums):
            return None
        result = []

        nums.sort()
        for i, val in enumerate(nums):
            if i > 0 and val == nums[i-1]:
                continue
            left = i+1
            right = len(nums)-1
            while left < right:
                tripleSum = nums[i] + nums[left] + nums[right]
                if tripleSum == target:
                    result.append([nums[i], nums[left], nums[right]])
                    left += 1
                    right -= 1
                elif tripleSum < target:
                    left += 1
                elif tripleSum > target:
                    right -= 1
        return result


nums = [-1, 0, 1, 2, -1, -1]
sol = Solution()
result = sol.threeSum(nums, 0)
print(result)

nums1 = [-3, 3, 4, -3, 1, 2, -7]
sol1 = Solution()
result1 = sol1.threeSum(nums1, 0)
print(result1)

