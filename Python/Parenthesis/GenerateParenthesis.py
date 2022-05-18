#Leetcode 22
class solution:
    def generateParenthesis(self, n:int):
        result = []
        stack = []
        self.calculateParenthesis(n, 0, 0, stack, result)
        return result

    def calculateParenthesis(self, n:int, openN:int, closeN:int, stack:list, result:list):
        if openN == closeN == n:
            result.append(".".join(stack))
            return
        if openN < n:
            stack.append("(")
            self.calculateParenthesis(n,openN+1, closeN,stack,result)
            stack.pop()
        if closeN < openN:
            stack.append(")")
            self.calculateParenthesis(n,openN,closeN+1, stack, result)
            stack.pop()

sol = solution()
print(sol.generateParenthesis(3))


