#Algoexpert
#Time Complexity O(n) and Space complexity o(n)
class Solution:
    def square(self, array:list) -> list:
        if len(array) == 0 :
            return None
        smallIdx = 0
        largeIdx = len(array)-1
        squares = [0 for i in array]

        for idx in reversed(range(len(array))):
            small = array[smallIdx]
            large = array[largeIdx]

            if abs(small) > abs(large):
                squares[idx] = small * small
                smallIdx += 1
            else:
                squares[idx] = large * large
                largeIdx -= 1
        return squares


sol = Solution()
array = [-4, -3, 0, 1, 2, 3]
squares = sol.square(array)
print(squares)