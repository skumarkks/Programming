def longestSubstringWithKReplacement(str, k):
    if(len(str) == 0) : return 0

    startIdx = 0
    endIdx = 0
    maxLenth = 0
    repeatingChar = 0
    charFrequency = {}

    for endIdx in range(len(str)):
        rightChar = str[endIdx]
        if rightChar not in charFrequency:
            charFrequency[rightChar] = 0
        charFrequency[rightChar] += 1

        repeatingChar = max(repeatingChar, charFrequency[rightChar])

        while(endIdx-startIdx+1-repeatingChar > k):
            leftChar = str[startIdx]
            charFrequency[leftChar] -= 1
            startIdx += 1
        maxLength = max(maxLenth, endIdx-startIdx+1)

    return maxLength

def main():
    print("Maximum Length " + str(longestSubstringWithKReplacement("BAAAB", 2)))

main()