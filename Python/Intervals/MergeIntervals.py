class Solution:
    def mergeintervals(self, intervals:list) -> list:
        intervals.sort(key=lambda i:i[0])
        output = [intervals[0]]

        for start, end in intervals[1:]:
            lastend = output[-1][1]
            if lastend >= start:
                output[-1][1] = max(lastend, end)
            else:
                output.append([start, end])
        return output


intervals = [[1, 3], [4, 6], [2, 10], [15, 18]]
sol = Solution()
output = sol.mergeintervals(intervals)
print(output)