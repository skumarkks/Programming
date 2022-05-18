def maxLengthNoRepeatCharSubstring(str):
    if(len(str) == 0):
        return 0

    startIdx = 0
    endIdx = 0
    maxLength = 0
    resString = ""
    charIndexMap = {}

    for endIdx in range(len(str)):
        rightChar = str[endIdx]
        if rightChar in charIndexMap:
            startIdx = max(startIdx, charIndexMap[rightChar]+1)
        charIndexMap[rightChar] = endIdx

        curLengh = maxLength
        maxLength = max(maxLength, endIdx-startIdx+1)
        if curLengh < maxLength:
            resString = str[startIdx:endIdx+1]

    return resString

def main():
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("aabccd")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("abbbb")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("abbbbcdd")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("a")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring(" ")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("  ")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("aau")))
    print("Max non-repeating character length : " + str(maxLengthNoRepeatCharSubstring("abcabcbb")))

main()