
import math
# when the numbers contains only positive integers
def smallest_subarray_with_given_sum(targetSum, arr):
    if len(arr) == 0:
        return 0

    startIdx = 0
    min_len = math.inf
    sum = 0

    for endIdx in range(0, len(arr)):
        sum += arr[endIdx]
        while sum >= targetSum:
            min_len = min(min_len, endIdx - startIdx + 1)
            sum -= arr[startIdx]
            startIdx += 1
    if min_len == math.inf:
        return 0
    return min_len

def main():
  #print("Smallest subarray length: " + str(smallest_subarray_with_given_sum(7, [2, 1, 5, 2, 3, 2])))
  #print("Smallest subarray length: " + str(smallest_subarray_with_given_sum(7, [2, 1, 5, 2, 8])))
  #print("Smallest subarray length: " + str(smallest_subarray_with_given_sum(8, [3, 4, 1, 1, 6])))
  print("Smallest subarray length: " + str(smallest_subarray_with_given_sum(6, [2, 2, 5, 1, 100])))


main()



