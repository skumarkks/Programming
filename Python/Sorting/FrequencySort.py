from heapq import *


def frequencySort(str):
    if(len(str) == 0):
        return []

    charfreqMap = {}
    
    for ch in str:
        charfreqMap[ch] = charfreqMap.get(ch, 0) + 1

    maxheap = []

    for ch, freq in charfreqMap.items():
        heappush(maxheap, (-freq, ch))

    sortedstring = []

    while maxheap:
        freq, ch = heappop(maxheap)

        for i in range(-freq):
            sortedstring.append(ch)

    return " ".join(sortedstring)

print(frequencySort("abcbab"))
