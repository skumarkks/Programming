class Solution:
    def islandPerimeter(self, grid) ->int:
        if not grid:
            return 0

        visited = set()
        rows, cols = len(grid), len(grid[0])
        
        def dfs(i, j):
            if i < 0 or j < 0 or i >= len(grid) or j >= len(grid[0]) or grid[i][j] == 0:
                return 1
            if (i, j) in visited:
                return 0
            visited.add((i, j))

            perim = dfs(i+1, j)
            perim += dfs(i-1, j)
            perim += dfs(i, j+1)
            perim += dfs(i, j-1)

            return perim

        for i in range(rows):
            for j in range(cols):
                if grid[i][j]:
                    return dfs(i,j)
sol = Solution()
grid = [
    [0,1,0,0],
    [1,1,1,0],
    [0,1,0,0],
    [1,1,0,0]
]
perim = sol.islandPerimeter(grid)
print(perim)


