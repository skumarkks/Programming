# if there are m length of nums1 and n length of nums2
# Time complexity O(m+n)
# space complexity O(m*n)

class Solution:
    def findLength(self, nums1, nums2):
        row, col = len(nums1)+1, len(nums2)+1
        arr = [[0 for i in range(col)] for j in range(row)]

        max = 0

        for i in range(1, len(nums1)+1):
            for j in range(1, len(nums2)+1):
                if nums1[i-1] == nums2[j-1]:
                    arr[i][j] = arr[i - 1][j - 1] + 1
                    if max < arr[i][j]:
                        max = arr[i][j]

        for i in range()
        return max

#find the longest substring here is is [3,2,1] of length 3 hence length of 3.
nums1 = [1,2,3,2,1]
nums2 = [3,2,1,4,7]

sol = Solution()
result = sol.findLength(nums1, nums2)
print(result)