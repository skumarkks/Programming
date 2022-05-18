#Leetcode - 138
#Time Complexity O(n)
#Space Complexity O(n) for storing
class Node:
    def __init__(self, val:int, next:'Node' = None, random:'Node'= None) -> 'Node':
        self.val = val
        self.next = None
        self.random = None

class Solution :
    def CopyRandomList(self, head:'Node') -> 'Node':
        OldToCopy = {None: None}

        cur = head
        while cur:
            copy = Node(cur.val)
            OldToCopy[cur] = copy
            cur = cur.next
        cur = head
        while cur:
            copy = OldToCopy[cur]
            copy.next = OldToCopy[cur.next]
            copy.random = OldToCopy[cur.random]
            cur = cur.next
        return OldToCopy[head]

    def NodePrint(self, cur: 'Node'):
        while cur:
            print(cur.val)
            cur = cur.next


sol = Solution()
node1 = Node(7)
node2 = Node(13)
node1.next = node2
node3 = Node(11)
node2.next = node3
node4 = Node(10)
node3.next = node4
node5 = Node(1)
node4.next = node5
node5.next = None
node1.random = None
node2.random = node1
node3.random = node5
node4.random = node3
node5.random = node1

head = sol.CopyRandomList(node1)
sol.NodePrint(head)


