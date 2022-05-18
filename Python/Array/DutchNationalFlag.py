#Leetcode 75
class Solution:
    def numsort(self, arr: list):
        if len(arr) == 0:
            return arr
        low = 0
        mid = 0
        high = len(arr) - 1
        while mid <= high:
            if arr[mid] == 0:
                self.swap(arr, low, mid)
                low += 1
                mid += 1
            elif arr[mid] == 1:
                mid += 1
            elif arr[mid] == 2:
                self.swap(arr, mid, high)
                high -= 1
        return arr

    def swap(self, arr, i, j):
        temp = arr[i]
        arr[i] = arr[j]
        arr[j] = temp


#if __name__ == "main":
sol = Solution()
arr = sol.numsort([2, 1, 0, 2, 1, 0])
print(arr)
