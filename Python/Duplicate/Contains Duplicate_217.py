#Leet code 217: following code is working
# Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
#
class Solution:
    def containsDuplicate(selfself, nums:list)-> bool:
        dict = {}
        for i in range(len(nums)):
            if nums[i] in dict:
                return True
            else:
                dict[nums[i]] = i
        return False

sol = Solution()
nums = [1, 2, 3, 1]
print(sol.containsDuplicate(nums))

nums = [1, 0, 1, 1]
print(sol.containsDuplicate(nums))

nums = [1, 2, 3, 4]
print(sol.containsDuplicate(nums))