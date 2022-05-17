using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMatching
{
    class Program
    {
        public bool ExpressionMatch(string str)
        {
            if (str.Length == 0)
                return false;

            var stack = new Stack<char>();
            char[] openexpression = {'(', '{', '['};
            char[] closeexpression = {')', '}', ']'};


            foreach (var ch in str)
            {
                if (openexpression.Contains(ch))
                {
                    stack.Push(ch);
                }
                else if(closeexpression.Contains((ch)))
                {
                    if (stack.Count == 0) return false;
                    char currentch = stack.Pop();


                    if (currentch == '(')
                    {
                        if (ch != ')') return false;
                    }
                    else if (currentch == '{')
                    {
                        if (ch != '}') return false;
                    }
                    else if (currentch == '[')
                    {
                        if (ch != ']') return false;
                    }
                }
            }
            
            return stack.Count == 0 ? true : false ;
        }
        static void Main(string[] args)
        {
            var sol = new Program();
            string str = "{ () }[]";
            if(sol.ExpressionMatch(str))
                Console.WriteLine("Balanced");
            else
            {
                Console.WriteLine("Unbalanced");
            }


            str = "{{{{";
            if (sol.ExpressionMatch(str))
                Console.WriteLine("Balanced");
            else
            {
                Console.WriteLine("Unbalanced");
            }
        }
    }
}
