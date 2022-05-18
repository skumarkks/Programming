class Solution:
    def searchRotatedArray(selfself, nums:list, target:int)->int:
        start, end = 0, len(nums)-1
        while start < end:
            mid = int((start + end)/2)
            if target == nums[mid]:
                return mid
            if nums[mid] >= nums[start]:
                if target >= nums[start] and target < nums[mid]:
                    end = mid-1
                else:
                    start = mid+1
            else:
                if target <= nums[end] and target < nums[mid]:
                    start = mid +1
                else:
                    end = mid -1

    def FindPivot(self, nums:list, low:int, high:int )->int:
        while low <= high:
            mid = (low + high)//2
            if nums[mid] > nums[mid+1]:
                return nums[mid+1]
            elif nums[low] > nums[mid]:
                return self.FindPivot(nums, low, mid-1)
            else:
                return self.FindPivot(nums,mid+1,high)


sol = Solution()
num1 = [4,5,6,7,8,0,1,2,3]
target = 6
result = sol.searchRotatedArray(num1,target)
print(result)

num1 = [4,5,6,7,8,0,1,2,3]
target = 2
result = sol.searchRotatedArray(num1,target)
print(result)


nums = [9, 12, 15, 17, 25, 28, 32, 37,3, 5, 7, 8]
result = sol.FindPivot(nums, 0,len(nums)-1)
print(result)

nums = [8, 9, 10,11,1,2,3]
result = sol.FindPivot(nums, 0,len(nums)-1)
print(result)



