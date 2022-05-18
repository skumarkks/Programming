# Definition for singly-linked list.
class ListNode:
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next



class Solution:
    def display(self, root):
        while root is not None:
            print(root.val)
            root = root.next


    def removeNthFromEnd(self, head: ListNode, n: int) -> ListNode:
        dummy = ListNode(0)
        dummy.next = head
        right = head
        left = dummy

        while n > 0 and right:
            right = right.next
            n -= 1

        while right:
            left = left.next
            right = right.next

        left.next = left.next.next
        return dummy.next

node10 = ListNode(10)
node9 = ListNode(9, node10)
node8 = ListNode(8, node9)
node7 = ListNode(7, node8)
node6 = ListNode(6, node7)
node5 = ListNode(5, node6)
node4 = ListNode(4, node5)
node3 = ListNode(3, node4)
node2 = ListNode(2, node3)
node1 = ListNode(1, node2)

sol = Solution()
sol.display(node1)
result = sol.removeNthFromEnd(node1, 10)
sol.display(result)
