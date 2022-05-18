from collections import deque

# Definition for a binary tree node.
class TreeNode:
     def __init__(self, val, left, right):
         self.val = val
         self.left = left
         self.right = right

class Solution:
    def findLeaves(self, root):
        if root is None:
            return None

        queue = deque()

        queue.append(root)
        queue.append(None)

        prev = None

        result = []
        leaves = []

        while True:
            node = queue.popleft()

            if node is None:
                queue.append(None)
                result.append(leaves)
            elif node is None and prev is None:
                break
            else:
                leaves.append(node.val)

            prev = node

            if node is not None and node.left is not None:
                queue.append(node.left)

            if node is not None and node.right is not None:
                queue.append(node.right)

        return result.reverse()

node1 = TreeNode(1, None, None)
node2 = TreeNode(2, None, None)
node3 = TreeNode(3, None, None)
node1.left = node2
node1.right = node3

node4 = TreeNode(1, None, None)
node5 = TreeNode(2, None, None)
node6 = TreeNode(3, None, None)

node2.left = node4
node2.right = node5

node3.left = node6


sol = Solution()
print(sol.findLeaves(node1))

