
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []



class Solution:
    def cloneGraph(self, node: 'Node') -> 'Node':
        if not node:
            return None

        oldToNew = {}

        def bfs(node):
            if node in oldToNew[node]:
                return oldToNew[node]

            copy = Node(node.val)
            oldToNew[node] = copy

            for nei in node.neighbour:
                copy.neighbour.append(bfs(nei))
            return copy