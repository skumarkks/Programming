#Leetcode 219
#Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array
# such that nums[i] == nums[j] and abs(i - j) <= k.

class Solution:
    def containDuplicate(self, nums:list, k :int )->bool:
        dict = {}

        for i in range(len(nums)):
            if nums[i] in dict:
                j = nums[i]
                if abs(i-j) <= k:
                    return True
                else:
                    dict[nums[i]] = i
            else:
                dict[nums[i]] = i
        return False


