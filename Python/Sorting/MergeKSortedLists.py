from heapq import *

class ListNode:
    def __init__(self, Value):
        self.value = Value
        self.next = None
    def __lt__(self, other):
        return self.value < other.value

def mergelist(lists):
    minHeap = []

    for root in lists:
        if root is not None:
            heappush(minHeap, root[0])

    resultHead, resultTail = None, None

    while minHeap:
        node = heappop(minHeap)

        if resultHead is None:
            resultHead = resultTail = node
        else:
            resultTail.next = node
            resultTail = resultTail.next

        if node.next is not None:
            heappush(minHeap, node.next)

    return resultHead


def main():
    l1 = ListNode(2)
    l1.next = ListNode(6)
    l1.next.next = ListNode(8)

    l2 = ListNode(3)
    l2.next = ListNode(6)
    l2.next.next = ListNode(7)

    l3 = ListNode(1)
    l3.next = ListNode(3)
    l3.next.next = ListNode(4)

    result = mergelist([l1, l2, l3])

    while result != None:
        print(str(result.Value))
        result = result.next


main()






