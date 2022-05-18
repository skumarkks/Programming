from heapq import *

def kthsmallestnumber(nums, k):
    n = len(nums)
    if n*k == 0:
        return []

    maxheap = []
    for i in range(k):
        heappush(maxheap,-nums[i])
    for i in range(k,n):
        if -nums[i] > maxheap[0]:
            heappop(maxheap)
            heappush(maxheap,-nums[i])

    return -maxheap[0]

kthsmallest = kthsmallestnumber([8,12,-3,1,5,6],3)
print(kthsmallest)