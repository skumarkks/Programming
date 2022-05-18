class solution:
    def productExceptSelf(self, nums:list)->list:
        result = [1]*(len(nums))
        prefix = 1
        for i in range(len(nums)):
            result[i] = prefix
            prefix *= nums[i]

        postfix = 1
        for i in range(len(nums)-1,-1,-1):
            result[i] *= postfix
            postfix *= nums[i]
        return result

sol = solution()
nums = [1,2,3,4]
print(sol.productExceptSelf(nums))


