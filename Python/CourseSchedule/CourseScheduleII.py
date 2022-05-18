from types import typelist
class Solution:
    def findOrder(self, numCourses:int, prerequisites:list[list[int]]) -> list:
        output = []
        if numCourses > 1 and len(prerequisites) == 0:
            for i in reversed(range(numCourses)):
                output.append(i)
            return output

        courseMap = {c: [] for c in range(numCourses)}

        courseList = []
        for i in range(numCourses):
            courseList.append(i)

        for crs, pre in prerequisites:
            courseMap[crs].append(pre)

        output = []
        visited = set()
        cycle = set()

        def dfs(crs):
            if crs in cycle:
                return False
            if crs in visited:
                return True
            cycle.add(crs)
            for pre in courseMap[crs]:
                if dfs(pre) == False:
                    return False
                cycle.remove(crs)
                visited.add(crs)
                output.append(crs)
                return True

        for c in courseList:
            if dfs(c) == False:
                return []
        return output

sol = Solution()
result = sol.findOrder(1, [])
print(result)

