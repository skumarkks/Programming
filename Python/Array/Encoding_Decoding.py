class solution:
    def encoding(self, strs:list)-> str:
        result = ""
        for st in strs:
            result += (str(len(st))+"#"+st)
        return result

    def decoding(self, s:str)->list:
        result, i = [], 0
        while i < len(s):
            j = i
            while s[j] != "#":
                j += 1
            length = int(s[i:j])
            result.append(s[j+1 : j+1+length])
            i = j+1+length
        return result

sol = solution()
result = sol.encoding(["neet", "code"])
print(sol.decoding(result))
