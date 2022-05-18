from heapq import *
#time complexity O(klogn)
def KfrequentNumber(nums,k):
    if len(nums) == 0:
        return []

    minheap = []
    frequencymap = {}
    result = []

    for num in nums:
        frequencymap[num] = frequencymap.get(num, 0) + 1

    for num, frequency in frequencymap.items():
        heappush(minheap, (frequency, num))
        if len(minheap) > k:
            heappop(minheap)

    for i in range(len(minheap)):
        result.append(heappop(minheap)[1])

    return result


#Bucket sorting
def kmostfrequentNumbers(nums:list, k:int) ->list:
    count = {}
    freMap = [[] for i in range(len(nums)+1)]
    result = []

    for val in nums:
        if val not in count:
            count[val] = 0
        count[val] += 1

    for i,count in count.items():
        freMap[count].append(i)

    for i in range(len(freMap)-1, 0, -1):
        for n in freMap[i]:
            result.append(n)
            if len(result) == k:
                return result

nums = [1,1,1,1,2,2,3,3,3,100]
print(KfrequentNumber(nums, 3))
print(kmostfrequentNumbers(nums, 3))
