class Solution:
    def combinationalSum(self, nums:list, target:int)->list:
        subsets = []
        subset = []
        total = 0
        self.calculateCombinationalSum(nums, 0, total, target, subset, subsets)
        return subsets

    def calculateCombinationalSum(self, nums:list, i:int, total:int,target:int, subset:list, subsets:list):
        if total == target:
            subsets.append(subset.copy())
            return
        if i >= len(nums) or total > target:
            return

        subset = subset + [nums[i]]
        self.calculateCombinationalSum(nums, i, total+nums[i], target, subset, subsets)
        subset.pop()
        self.calculateCombinationalSum(nums, i+1, total, target, subset,  subsets)


sol = Solution()
nums = [2,3,4,5]
target = 6
result = sol.combinationalSum(nums, target)
print(result)
