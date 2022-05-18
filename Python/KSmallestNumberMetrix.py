from heapq import *

def find_Kth_smallest(matrix, k):
    minHeap = []
    for i in range(min(k,len(matrix))):
        heappush(minHeap, (matrix[i][0], 0, matrix[i]))
    count, mVal = 0, 0
    while minHeap:
        mVal, i, row = heappop(minHeap)
        count += 1
        if count == k:
            break
        if len(row) > i+1:
            heappush(minHeap, (row[i+1], i+1, row) )

     return mVal

def main():
    print("Kth smallest number is: " +
          str(find_Kth_smallest([[2, 6, 8], [3, 7, 10], [5, 8, 11]], 5)))


main()