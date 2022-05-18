import array as arr

def max_sub_array_of_size_k(k, arr):
    if len(arr) == 0 or len(arr) < k :
        return 0

    max_sum = 0
    startIdx = 0
    endIdx = 0
    i = 0
    sum = 0

    while endIdx < len(arr):
        sum += int(arr[endIdx])

        if endIdx >= k-1:
            if sum > max_sum:
                max_sum = sum
            sum -= arr[startIdx]
            startIdx = startIdx+1
        endIdx += 1

    return max_sum


def main():
    print("Maximum sum of a subarray of size K: " + str(max_sub_array_of_size_k(3, [2, 1, 5, 1, 3, 2])))
    print("Maximum sum of a subarray of size K: " + str(max_sub_array_of_size_k(2, [2, 3, 4, 1, 5])))
    print("Maximum sum of a subarray of size K: " + str(max_sub_array_of_size_k(2, [])))
    print("Maximum sum of a subarray of size K: " + str(max_sub_array_of_size_k(3, [2, 3])))

main()

