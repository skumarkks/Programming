from heapq import *

def find_k_largest_numbers(nums, k) :
    n = len(nums)
    if n * k == 0:
        return []

    minheap = []

    for i in range(k) :
        heappush(minheap,nums[i])

    for k in range(k,n):
        if nums[i] > minheap[0]:
            heappop(minheap)
            heappush(minheap,nums[i])
    return list(minheap)

result = find_k_largest_numbers([1,3,-3,2,4,5,7,5,8,9], 3)
print(result)



