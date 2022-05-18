def longest_substring_with_k_distinct(str,k):
    if len(str) == 0 :
        return 0
    if(len(str) < k):
        return 0

    startIdx = 0
    endIdx = 0
    maxLength = 0
    charFreq = {}

    for endIdx in range(len(str)):
        rightChar = str[endIdx]

        if rightChar not in charFreq :
            charFreq[rightChar] = 1
        else:
            charFreq[rightChar] += 1

        while(len(charFreq) > k):
            leftChar = str[startIdx]
            charFreq[leftChar] -= 1
            if(charFreq[leftChar] == 0):
                charFreq.pop(leftChar)
            startIdx += 1

        maxLength = max(maxLength, endIdx-startIdx+1)

    return maxLength


def main():
    print("LongestSubstring : " + str(longest_substring_with_k_distinct("araaci",2)))
    print("LongestSubstring : " + str(longest_substring_with_k_distinct("araaci", 1)))
    print("Length of the longest substring: " + str(longest_substring_with_k_distinct("cbbebi", 3)))


main()
