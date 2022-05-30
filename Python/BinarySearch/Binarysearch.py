"""
#Time complexity O(logn) and space complexity O(1)
class Solution:
    def search(self, nums: List[int], target: int) -> int:
        if len(nums) == 0:
            return -1
        start, end = 0, len(nums) - 1
        return self.binarysearch(nums, target, start, end)

    def binarysearch(self, nums, target, start, end):
        start, end = 0, len(nums) - 1
        while start <= end:
            mid = (start + end) // 2
            if nums[mid] == target:
                return mid
            elif target < nums[mid]:
                end = mid - 1
            elif target > nums[mid]:
                start = mid + 1
        return -1
"""
#Time complexity O(logn) and space complexity O(logn)
class Solution:
    def search(self, nums: list, target: int) -> int:
        if len(nums) == 0:
            return -1
        start, end = 0, len(nums)-1
        return self.BinarySearch(nums, target, start, end)

    def BinarySearch(self, nums:list, target:int, start:int, end:int):
        if start > end:
            return -1
        mid = (start+end)//2

        if nums[mid] == target:
            return mid
        elif target < nums[mid]:
            return self.BinarySearch(nums, target, start, mid-1)
        elif target > nums[mid]:
            return self.BinarySearch(nums, target, mid+1, end)
        return -1

sol = Solution()
nums = [1,2,3,4,56]
print(sol.search(nums, 56))