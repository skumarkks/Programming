using System;
using System.Collections.Generic;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length == 0 || t.Length == 0)
            return null;

        var charfrequency = new Dictionary<char, int>();

        foreach (var ch in t)
        {
            if (!charfrequency.ContainsKey(ch))
            {
                charfrequency.Add(ch, 0);
            }
            charfrequency[ch] += 1;
        }

        int startIdx = 0;
        int endIdx = 0;
        int minLength = Int32.MaxValue;
        int matched = 0;
        int substringStartIdx = 0;

        while (endIdx < s.Length)
        {
            char rightCh = s[endIdx];
            if(charfrequency.ContainsKey(rightCh))
            {
                charfrequency[rightCh] -= 1;
                if (charfrequency[rightCh] >= 0)
                    matched += 1;
            }

            while(matched == t.Length)
            {
                int currentLength = endIdx - startIdx + 1;
                if (minLength > currentLength)
                {
                    minLength = currentLength;
                    substringStartIdx = startIdx;
                }

                char leftCh = s[startIdx];
                startIdx += 1;

                if(charfrequency.ContainsKey(leftCh))
                {                    
                    if (charfrequency[leftCh] == 0)
                        matched -= 1;
                    charfrequency[leftCh] += 1;
                }

            }
            endIdx += 1;
        }

        return minLength <= s.Length ? s.Substring(substringStartIdx, minLength) : "";

    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        string s = "ABAACBAB";
        string t = "ABC";
        string result = sol.MinWindow(s, t);
        Console.WriteLine(result);



        s = "A";
        t = "A";
        result = sol.MinWindow(s, t);
        Console.WriteLine(result);
    }
    
}