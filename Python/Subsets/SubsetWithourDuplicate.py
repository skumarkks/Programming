def finsubsets(self, nums: list):
    subset = []
    subsets = []
    self.subsetHelper(nums, 0, subset, subsets)
    return subsets


def subsetHelper(self, nums: list, i: int, subset: list, subsets: list) -> list:
    if i == len(nums):
        subsets.append(subset.copy())
        return
    else:
        while (i > 0 and nums[i-1] == nums[i]):
            continue
        self.subsetHelper(nums, i + 1, subset + [nums[i]], subsets)
        self.subsetHelper(nums, i + 1, subset, subsets)


sol = Solution()
nums = [1, 2, 3, 4]
result = sol.SubSets(nums)
print("This is the result")
print(result)


result = sol.finsubsets(nums)
print("This is the result")
print(result)