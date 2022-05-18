import math
import sys

# time complexity O(logN) and space complexity O(k)
from typing import List

class Solution:
    def findClosestElements(self, arr, k, x):

        closest = sys.maxsize
        closestIdx = self.findClosest(arr, k, 0, len(arr) - 1, closest, -1)  # O(log N)
        return self.GetkClosest(arr, closestIdx, k, x)  # O(k)

    def findClosest(self, arr, target, low, high, closest, closestidx):
        if low > high:
            return closestidx

        mid = int((low + high) / 2)
        if abs(arr[mid] - target) < closest:
            closest = arr[mid]
            closestidx = mid

        if arr[mid] < target:
            return self.findClosest(arr, target, mid + 1, high, closest, closestidx)
        elif arr[mid] > target:
            return self.findClosest(arr, target, 0, mid - 1, closest, closestidx)
        elif arr[mid] == target:
            return closestidx

    def GetkClosest(self, arr, closestIdx, target, k):
        result = []

        result.append(arr[closestIdx])
        rightIdx = closestIdx + 1
        leftIdx = closestIdx - 1

        while (len(result) < k):
            if leftIdx >= 0:
                leftVal = abs(arr[leftIdx] - target)

            if rightIdx < len(arr):
                rightVal = abs(arr[rightIdx] - target)

            if (leftIdx >= 0 and rightIdx < len(arr) and leftVal <= rightVal):
                result.append(arr[leftIdx])
                leftIdx -= 1
            elif (leftIdx >= 0 and rightIdx < len(arr) and leftVal >= rightVal):
                result.append(arr[rightIdx])
                rightIdx += 1
            elif leftIdx < 0:
                result.append(arr[rightIdx])
                rightIdx += 1
            elif rightIdx > len(arr):
                result.append(arr[leftIdx])
                leftIdx -= 1
        result.sort()

        return result

# from the given array of numbers find 4 values closest to x
nums = [1, 2, 3, 4, 5]
x = 3
k = 4

sol = Solution()
print(sol.findClosestElements(nums, x, k))
