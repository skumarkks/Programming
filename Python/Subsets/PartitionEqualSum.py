# Leet code:416
# Time and space complexity O(2^n)

class Solution:
    def partitionequalsum(self, nums:list) -> list:
        target = 0
        for num in nums:
            target += num
        if target % 2:
            return False
        subsets = []
        subset = []
        self.calculatepartitionequalsum(nums, 0, 0, target//2, subset, subsets)
        return len(subsets) > 0

    def calculatepartitionequalsum(self, nums:list, i:int, total:int, target:int, subset:list, subsets:list):
        if i == len(nums):
            if total == target:
                subsets.append(subset.copy())
            return
        else:
            self.calculatepartitionequalsum(nums, i+1, total+nums[i], target, subset+[nums[i]], subsets)
            self.calculatepartitionequalsum(nums, i+1, total, target, subset, subsets)


sol = Solution()
nums = [1, 5, 11, 5]
result = sol.partitionequalsum(nums)
print(result)

nums = [1, 2, 3, 5]
result = sol.partitionequalsum(nums)
print(result)



