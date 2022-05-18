class TreeNode :
    def __init__(self,val, left, right):
        self.val = val
        self.left = left
        self.right = right
        heightLeaves = []

class Solution:
    def FindHeight(self, root: TreeNode) -> int:
        if not root:
            return -1

        leftHeight = self.FindHeight(self.root.left)
        rightHeight = self.FindHeight(self.root.right)

        currentHeight = 1 + max(leftHeight, rightHeight)

        if len(self.heightLeaves) == currentHeight:
            self.heightLeaves.append([])
        self.heightLeaves[currentHeight] = self.root.val;
        return currentHeight

    def FindLeaves(self, root: TreeNode) -> list:
        self.FindHeight(root)
        return self.heightLeaves;

node1 = TreeNode(1, None, None)
node2 = TreeNode(2, None, None)
node3 = TreeNode(3, None, None)
node4 = TreeNode(4, None, None)
node5 = TreeNode(5, None, None)

node1.left = node2
node1.right = node3

node2.left =node4
node2.right = node5

sol = Solution()
result = sol.FindLeaves(node1)
print(result)