class KadanesAlgorithm:
    def maxsumsubarray(self, nums):
        maxsumendinghere = nums[0]
        maxsumsofar = nums[0]

        for i in range(1,len(nums)):
            maxsumendinghere = max(maxsumendinghere + nums[i], nums[i])
            maxsumsofar = max(maxsumsofar, maxsumendinghere)

        return maxsumsofar

sol = KadanesAlgorithm()
nums = [-2, 2, 5, -11, 6]
sum = sol.maxsumsubarray(nums);
print(sum)
