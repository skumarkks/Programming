#Leetcode : 200

import collections

class Solution:
    def FindIsland(self, grid: list) -> int:
        if len(grid) == 0:
            return 0
        rows, cols = len(grid), len(grid[0])
        visit = set()
        island = 0

        def Bsf(r, c):
            q = collections.deque()
            q.append((r,c))
            visit.add((r,c))

            while q:
                row, col = q.popleft()
                directions = [[1,0],[0,1],[-1,0],[0,-1]]

                for dr, dc in directions:
                    if(row+dr) in range(rows) and \
                      (col+dc) in range(cols) and \
                      grid[row+dr][col+dc] == 1 and \
                    (row+dr, col+dc) not in visit :
                        q.append((row+dr,col+dc))
                        visit.add((row+dr,col+dc))
        for r in range(rows):
            for c in range(cols):
                if grid[r][c] == 1 and (r,c) not in visit:
                    Bsf(r,c)
                    island += 1
        return island


grid = [[1,1,1,0,0],
        [1,1,0,0,0],
        [1,0,0,1,1],
        [1,1,1,0,0],
        [1,1,0,0,0]]
sol = Solution()
island = sol.FindIsland(grid)
print(island)




