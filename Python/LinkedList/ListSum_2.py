class TreeNode:
    def __init__(self, val:int, next:'TreeNode'=None):
        self.val = val
        self.next = next

    def display(self, root:'TreeNode'):
        while root:
            print(root.val)
            root = root.next

    def listSum(self, list1:'TreeNode', list2:'TreeNode')-> 'TreeNode':
        dummy = TreeNode(0)
        current = dummy
        carry = 0

        while list1 or list2 or carry:
            val1 = list1.val if list1 else 0
            val2 = list2.val if list2 else 0

            sum = val1 + val2 + carry
            carry = sum // 10
            sum = sum % 10

            current.next = TreeNode(sum)
            current = current.next

            list1 = list1.next if list1 else None
            list2 = list2.next if list2 else None

        return dummy.next


l3 = TreeNode(3)
l2 = TreeNode(4, l3)
l1 = TreeNode(2, l2)

x3 = TreeNode(4)
x2 = TreeNode(6, x3)
x1 = TreeNode(5, x2)

s1 = l1.listSum(l1, x1)
s1.display(s1)

l3 = TreeNode(4)
l2 = TreeNode(6, l3)
l1 = TreeNode(5, l2)

x3 = TreeNode(3)
x2 = TreeNode(3, x3)
x1 = TreeNode(4, x2)
x0 = TreeNode(2, x1)

s1 = l1.listSum(l1, x0)
s1.display(s1)








