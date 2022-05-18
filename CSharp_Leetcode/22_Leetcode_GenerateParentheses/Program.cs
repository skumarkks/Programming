using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Leetcode_GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            string output = null;

            if (n == 0)
            {
                return null;
            }
            if (n == 1)
                return null;

            BackTrack(result, output, 0, 0, n);
            return result;
        }

        private void BackTrack(IList<string> result,string output, int open, int close, int n)
        {
            if(close == n)
            {
                result.Add(output);
                //output = null;
                return;
            }
            else
            {

                if (open > close)
                {
                    BackTrack(result, output + ")", open, close + 1, n);
                }

                if (open < n)
                {
                    BackTrack(result, output+"(", open + 1, close, n);

                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            IList<string> result = sol.GenerateParenthesis(3);

            foreach (var item in result)
            {
                Console.WriteLine(result);
            }
        }
    }
}
