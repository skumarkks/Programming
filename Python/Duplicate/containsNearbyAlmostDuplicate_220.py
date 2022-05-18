#Not fully working
class Solution:
    def containsNearbyAlmostDuplicate(self, nums: list, k: int, t: int) -> bool:
        dict = {}

        for i in range(len(nums)):
            if nums[i] in dict:
                j = dict[nums[i]]
                if abs(nums[i] - nums[j]) <= t and abs(i - j) <= k:
                    return True
                else:
                    dict[nums[i]] = i
            else:
                dict[nums[i]] = i
        return False

sol = Solution()
nums = [8, 7, 15, 1, 6, 1, 9, 15]
k = 1
t = 3
print(sol.containsNearbyAlmostDuplicate(nums, k, t))

