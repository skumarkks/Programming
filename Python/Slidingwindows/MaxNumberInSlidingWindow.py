# in the deq keep index of element of the sliding window at any time
# if the index are out of the sliding windows popleft from the double ended queue
# deq[0] should of the max element index at any point in time


from collections import deque

def clean_deque(deq, nums, i, k):
    if deq and deq[0] == i -k:
        deq.popleft()

    while deq and nums[i] > nums[deq[-1]]:
        deq.pop()


def maxNumberInSlidingWindow(nums, k):
    n = len(nums)
    if n * k == 0:
        return []
    deq = deque()
    max_id = 0

# queue k element for the initial window of size k
    for i in range(k):
        clean_deque(deq, nums, i, k)
        deq.append(i)

        if nums[i] > nums[max_id]:
            max_id = i
    output = [nums[max_id]]

    for i in range(k, n):
        clean_deque(deq, nums, i, k)
        deq.append(i)
        output.append(nums[deq[0]])

    return output



# print(maxNumberInSlidingWindow([1, 2, 3, -2, 4], 3))
rlist = maxNumberInSlidingWindow([1,3,-1,-3,5,3,6,7], 3)
print(rlist)