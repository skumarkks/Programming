#Time complexity O(n) where n is the number of elements in the stack
#Space complexity O(n) where n is the number of elment in the stack probably n/2
class expressionmatch:
    def expressionmatching(self, str: str)-> bool:
        if len(str) == 0:
            return False
        stack = []
        for ch in str:
            if ch in ["(", "{", "["]:
                stack.append(ch)
            else:
                if len(stack) == 0:
                    return False

                currentch = stack.pop()
                if currentch == "(":
                    if ch != ")":
                        return False
                elif currentch == "{":
                    if ch != "}":
                        return False
                elif currentch == "[":
                    if ch != "]":
                        return False
        if len(stack) == 0 :
                return True
        else:
            return False


    def expressionmatchingKallowed(self, str, k):
        if len(str) == 0:
            return False
        stack = []
        for ch in str:
            if ch in ["(", "{", "["]:
                stack.append(ch)
            else:
                if len(stack) == 0:
                    return False

                currentch = stack.pop()
                if currentch == "(":
                    if ch != ")":
                        return False
                elif currentch == "{":
                    if ch != "}":
                        return False
                elif currentch == "[":
                    if ch != "]":
                        return False
        if len(stack) == 0 :
                return True
        else:
            return False


#This can be done linearly with out using a stack
#this is by using counters for each open character, the add/subtract it


expr = "{()}[]"
sol = expressionmatch()
if sol.expressionmatching(expr):
    print("Balanced")
else:
    print("Unbalanced")

expr = "{{{{{"
if sol.expressionmatching(expr):
    print("Balanced")
else:
    print("Unbalanced")

expr = "([){}"
if sol.expressionmatching(expr):
    print("Balanced")
else:
    print("Unbalanced")




