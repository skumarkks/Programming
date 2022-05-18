#Leetcode 96
class NumberOfTrees:
    def numTree(self, n:int) -> int:
        numTrees = [1]*(n+1)
        for i in range(2,n+1):
            total = 0
            for j in range(0, i):
                total += numTrees[j]*numTrees[i-j-1]
            numTrees[i] = total
        return numTrees[n]


sol = NumberOfTrees()
n = 3
print(sol.numTree(n))