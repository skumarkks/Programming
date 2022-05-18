class CMergeSort:
    def __init__(self):
        self.x = 0

    def mergesort(self, nums):
        l = 0;
        h = len(nums) - 1
        result = []
        self.mergeutil(nums, result, l, h)

    def mergeutil(self, nums, result, low, high):
        if low < high:
            mid = int((low + high) / 2)
            self.mergeutil(nums, result, low, mid)
            self.mergeutil(nums, result, mid + 1, high)
            self.merge(nums, result, low, mid, high)

    def merge(self, nums, result, low, mid, high):
        firstIdx = low
        secondIdx = mid + 1
        index = low

        while firstIdx <= mid and secondIdx <= high:
            if nums[firstIdx] <= nums[secondIdx]:
                result.insert(index, nums[firstIdx])
                firstIdx += 1
                index += 1
            else:
                result.insert(index, nums[secondIdx])
                secondIdx += 1
                index += 1

        while firstIdx <= mid:
            result.insert(index, nums[firstIdx])
            firstIdx += 1
            index += 1

        while secondIdx <= high:
            result.insert(index, nums[secondIdx])
            secondIdx += 1
            index += 1

        for i in range(0, high + 1):
            nums[i] = result[i]

        print(nums)


sol = CMergeSort()
nums = [2, 4, 5, 7, 1, 2, 3, 6]
sol.mergesort(nums)
print(nums)







