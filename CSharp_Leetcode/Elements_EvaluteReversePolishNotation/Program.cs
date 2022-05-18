using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_EvaluteReversePolishNotation
{
    class Program
    {
        public static int EvaluteReversePolishNotation(string[] inExpression)
        {
            // define the arithmatic key list
            string[] mathOp = {"+", "-", "*", "/"};

            // if the value is not in the arithmatic list and a numeric push to stack
            // if the value is in the arithmatic list pop the values and operate on it
            Stack<int> stack = new Stack<int>();
            foreach (var ch in inExpression)
            {
                int val = 0;
                
                if (!mathOp.Contains(ch))
                {
                    val = Int32.Parse(ch.ToString());
                    stack.Push(val);
                }

                
                if (mathOp.Contains(ch))
                {
                    if (string.Equals(ch,"+"))
                    {
                        int x = stack.Pop();
                        int y = stack.Pop();
                        val = x + y;
                    }
                    else if (string.Equals(ch, "-"))
                    {
                        int x = stack.Pop();
                        int y = stack.Pop();
                        val = y - x;
                    }
                    else if (string.Equals(ch, "*"))
                    {
                        val = stack.Pop() * stack.Pop();
                    }
                    else if (string.Equals(ch, "/"))
                    {
                        int x = stack.Pop();
                        int y = stack.Pop();
                        val = y / x;
                    }
                    stack.Push(val);
                }
            }
            return stack.Pop();

        }
        static void Main(string[] args)
        {

            
            //int result = EvaluteReversePolishNotation("23+4-");

            //"4135/+"
            //int result = EvaluteReversePolishNotation("21+3*");

            //string[] input = {"4", "13", "5", "/", "+"};
            string[] input = {"2", "1", "+", "3", "*"};
            int result = EvaluteReversePolishNotation(input);
            Console.WriteLine(result);
        }
    }
}
