#Find the median of a set of numbers

#Time complexity O(nlogn)
#Space Complexity O(n)
class Median:
    def __init__(self):
        self.list = []

    def add(self, val):
        self.list.append(val)

    def medianbySort(self):
        mlist = self.list

        if len(mlist) == 1:
            return mlist[0]
#Median should be on sorted array
        mlist.sort()
        if len(mlist) % 2 == 0 :
            l1 = int(len(mlist)/2)
            l2 = l1-1
            return (mlist[l1] + mlist[l2])/2
        else:
            return mlist[int(len(mlist)/2)]

sol = Median()
sol.add(1)
sol.add(3.5)
sol.add(4)
sol.add(2)

result = sol.medianbySort()
print(result)



