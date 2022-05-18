#Leet code 106

from collections import deque
class TreeNode:
    def __init__(self, val:int = 0, left:'TreeNode'=None, right:'TreeNode'=None):
        self.val = val
        self.right = right
        self.left = left

    def levelOrder(self, root):
        if root is None:
            return None
        queue = deque()
        queue.append(root)
        level = []
        while len(queue) > 0 :
            node = queue.popleft()
            level.append(node.val)

            if node.left is not None:
                queue.append(node.left)
            if node.right is not None:
                queue.append(node.right)
        return level


    def buildTree(self,inorder:list, postorder:list) -> 'TreeNode':
        if not inorder or not postorder:
            return

        root =TreeNode(postorder.pop())
        mid = inorder.index(root.val)

        #first do the right one
        root.right = self.buildTree(inorder[mid+1:], postorder)
        root.left = self.buildTree(inorder[:mid], postorder)
        return root


sol = TreeNode()
inorder = [9, 3, 15, 20, 7]
postorder =[9, 15, 7, 20, 3]
root = sol.buildTree(inorder, postorder)
print(sol.levelOrder(root))

