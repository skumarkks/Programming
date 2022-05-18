edges = [[1, 2], [1, 3], [2, 3]]
i = 0
for nei in edges[i]:
    print(nei)

intervals = [[6,1], [1,2], [2,3]]
intervals.sort(key=lambda i:i[0])
#intervals = [[]]
if intervals is not None:
    print(intervals)

