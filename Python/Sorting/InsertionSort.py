#Given an array of numbers use the insertion sort to sort the given number
# Time complexity O(n^2) and space complexity O(1)
class Sort:
    def InsertionSort(self, arr):
        if len(arr) == 0:
            return arr

        for j in range(1,len(arr)):
            key = arr[j]
            i = j - 1

            while i >= 0 and arr[i] > key:
                arr[i+1] = arr[i]
                i = i - 1
            arr[i+1] = key
        return arr

sol = Sort()
arr = [5, 2, 4, 6, 1, 3]
print(arr)
arr = sol.InsertionSort(arr)
print(arr)

arr1 = [5]
print(arr1)
arr1 = sol.InsertionSort(arr1)
print(arr1)

arr2 = [5, 1]
print(arr2)
arr2 = sol.InsertionSort(arr2)
print(arr2)


arr3 = [-1, -5]
print(arr3)
arr3 = sol.InsertionSort(arr3)
print(arr3)




