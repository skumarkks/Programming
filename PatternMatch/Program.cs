using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatch
{
    class Program
    {
        public static string[] PatternMatcher(string pattern, string str)
        {
            if (str.Length < pattern.Length) return null;
            bool isPatternStartwithX = NormalizePattern(ref pattern);

            int firstYPostion = -1;
            int numXbeforeYPattern = -1;
            int sizeOfY = -1;

            int numberOfX = 0;
            int numberOfY = 0;

            bool isFirstYPostion = false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'x')
                {
                    numberOfX++;
                }
                else
                {
                    if (!isFirstYPostion)
                    {
                        numXbeforeYPattern = i;
                        firstYPostion = i;
                        isFirstYPostion = true;
                    }
                    numberOfY++;
                }
            }

            return GetXandYMatch(pattern, str, numXbeforeYPattern, numberOfX, numberOfY, isPatternStartwithX);
        }

        public static string[] GetXandYMatch(string pattern, string str, int numXbeforeYPattern,int numberOfX, int numberOfY, bool isPatternStartwithX)
        {
            int sizeletX = 0;
            int positionOfY = 0;

            string strX;
            string strY;

            for (int i = 0; i < str.Length; i++)
            {
                strX = str.Substring(0, i+1);
                positionOfY = strX.Length * numXbeforeYPattern;
                
                int sizeOfY = (str.Length - strX.Length * numberOfX) / numberOfY;

                if (sizeOfY < 0) return new string[] { };

                strY = str.Substring(positionOfY, sizeOfY);

                if ((strX.Length * numberOfX + strY.Length * numberOfY) > str.Length || strX.Length == str.Length) return new string[]{};

                bool isPatternMatched = GenerateAndCompareString(strX, strY, pattern, str);

                if (isPatternMatched)
                {
                    if (isPatternStartwithX)
                        return new string[] { strX, strY };
                    else
                        return new string[] { strY, strX };
                }
            }

            return null;
        }

        public static bool GenerateAndCompareString(string strX, string strY, string pattern, string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char ch in pattern)
            {
                if (ch == 'x')
                {
                    sb.Append(strX);
                }
                else

                {
                    sb.Append(strY);
                }
            }

            return str == sb.ToString() ? true : false;

        }

        public static bool NormalizePattern(ref string pattern)
        {

            bool isPatternStartwithX = true;
            char[] newPattern = new char[pattern.Length];

            if (pattern[0] == 'y')
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (pattern[i] == 'x')
                        newPattern[i] = 'y';
                    else
                        newPattern[i] = 'x';
                }

                pattern = new string(newPattern);

                isPatternStartwithX = false;
            }

            return isPatternStartwithX;
        }

        static void Main(string[] args)
        {
            string pattern = "xxyxxy";
            string str = "gogopowerrangergogopowerranger";

            string[] result = Program.PatternMatcher(pattern, str);

            foreach (string st in result)
            {
                Console.WriteLine(st);
            }


            pattern = "yxx";
            str = "yomama";

            result = Program.PatternMatcher(pattern, str);

            foreach (string st in result)
            {
                Console.WriteLine(st);
            }

            pattern = "xyx";
            str = "thisshouldobviouslywrong";

            result = Program.PatternMatcher(pattern, str);

            foreach (string st in result)
            {
                Console.WriteLine(st);
            }

        }
    }
}
