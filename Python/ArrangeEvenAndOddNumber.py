class Solution:
    def ArrangeEvenAndOddNumber(self, A):
        next_even, next_odd = 0, len(A)-1
        while next_even < next_odd:
            if A[next_even] % 2 == 0:
                next_even += 1
            else:
                A[next_even], A[next_odd] = A[next_odd], A[next_even]
                next_odd -= 1
        return A

nums = [1,2,3,4,5,6]
sol = Solution()
result = sol.ArrangeEvenAndOddNumber(nums)

print(result)



