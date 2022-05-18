from heapq import *
class Median:
    def __init__(self):
        self.lo = []
        self.hi = []

    def add(self, val):
        lo = self.lo
        hi = self.hi
        heappush(lo, -val)
        vallo = -heappop(lo)
        heappush(hi, vallo)

        if len(lo) < len(hi):
            val = heappop(hi)
            heappush(lo, -val)

    def median(self):
        if len(self.lo) <= len(self.hi):
            return (-heappop(self.lo) + (heappop(self.hi)))/2
        else:
            return -heappop(self.lo)


sol = Median()
sol.add(1)
sol.add(3.5)
sol.add(4)
sol.add(2)

result = sol.median()
print(result)



