class TopKElement:
    def TopKRepeatedElement(self, nums:list, k :int)->list:
        if len(nums) < k:
            return None
        hashmap = {}
        for i in range(len(nums)):
            if nums[i] not in hashmap:
                hashmap[nums[i]] = 0
            hashmap[nums[i]] += 1

        freq = [[] for i in range(len(nums))]

        for i,values in hashmap.items():
            freq[values].append(i)

        result = []
        for lst in range(len(freq)-1,-1,-1):
            for i in freq[lst]:
                result.append(i)
                if len(result) == k:
                    return result








