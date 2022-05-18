# Leetcode 105
from collections import deque


class TreeNode:
    def __init__(self, val:int=0, left:'TreeNode'= None, right:'TreeNode'=None):
        self.val = val
        self.left = left
        self.right = right


    def levelOrder(self, root:'TreeNode') -> list:
        if root is None:
            return None
        result = []
        queue = deque()
        queue.append(root)

        while len(queue) > 0:
            node = queue.popleft()
            result.append(node.val)

            if node.left is not None:
                queue.append(node.left)
            if node.right is not None:
                queue.append(node.right)
        return result



class Solution:
    def BuildTree(self, preorder: list, inorder:list) -> 'TreeNode':
        if not preorder or not inorder:
            return None
        root = TreeNode(preorder[0])
        mid = inorder.index(preorder[0])

        root.left = self.BuildTree(preorder[1:mid+1], inorder[:mid])
        root.right = self.BuildTree(preorder[mid + 1:], inorder[mid+1:])

        return root


sol = Solution()
preorder = [3, 9, 20, 15, 7]
inorder = [9, 3, 15, 20, 7]
root = sol.BuildTree(preorder, inorder)
tr = TreeNode()
print(tr.levelOrder(root))


