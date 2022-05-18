import bisect


class Median:
    def __init__(self):
        self.list = []

    def add(self, val: int):
        bisect.insort(self.list, val)

    def median(self):
        list = self.list

        n = len(list)

        if n%2 == 0:
            li1 = int(n/2)
            li2 = li1-1
            return (list[li1] +list[li2])/2
        else:
            return list[int(n/2)]

sol = Median()
sol.add(1)
sol.add(3.5)
sol.add(4)
sol.add(2)

result = sol.median()
print(result)