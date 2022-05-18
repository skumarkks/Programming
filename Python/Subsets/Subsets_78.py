class SubsetSolution:
    def GetSubsets(self, nums: list, i: int, subset: list, subsets: list) -> None:
        if i == len(nums):
            subsets.append(subset.copy())
            return
        # Add the ith element for consideration
        subset = subset + [nums[i]]
        self.GetSubsets(nums, i + 1, subset, subsets)
        # delete the ith element from consideration
        subset.pop()
        self.GetSubsets(nums, i + 1, subset, subsets)

    def Subsets(self, nums: list) -> list:
        subsets = []
        subset = []
        self.GetSubsets(nums, 0, subset, subsets)
        return subsets

    def SubSetsIterative(self, nums:list) -> list:
        subsets = [[]]
        for ele in nums:
            for i in range(len(subsets)):
                currentSubset = subsets[i]
                subsets.append(currentSubset+[ele])
        return subsets



sol = SubsetSolution()
nums = [1, 2, 3]
result = sol.Subsets(nums)
print("This is the result")
print(result)
nums = [1, 2, 3]
result = sol.SubSetsIterative(nums)
print(result)
