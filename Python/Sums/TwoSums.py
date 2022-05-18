# Leet code -1,167
class TwoSum(object):
    """description of class"""
    #Time Complexity O(n) and space complexity O(n)
    def twosum(self, nums:list,target:int)-> list:
        premap = {}
        for i, n in enumerate(nums):
            dif = target - n
            if dif in premap:
                return [premap[dif], i]
            premap[n] = i
        return None

    #Time complexity O(nlogn) and Space Complexity O(1)
    def twosum_Sort(self, nums: list, target: int) -> list:
        nums.sort()
        left, right = 0, len(nums)-1

        while left < right:
            sum = nums[left] + nums[right]

            if sum == target:
                return [left, right]
            elif sum < target:
                left += 1
            elif sum > target:
                right -= 1
        return None




sol = TwoSum()
#nums = [2, 1, 5, 3]
nums = [3,0, 3]
target = 3
result = sol.twosum(nums, target)
print(result)
result = sol.twosum_Sort(nums, target)
print(result)



