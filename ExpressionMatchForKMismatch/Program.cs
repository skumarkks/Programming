using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMatchForKMismatch
{
    class Program
    {
        public bool isValid(string str, int k)
        {
            if (str.Length == 0) return true;
            char[] openExp = new char[] {'(', '{', '['};
            char[] arrStr = str.ToCharArray();
            Stack<char> stack = new Stack<char>();
            int matched = 0;
            int mismatched = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = arrStr[i];

                if (openExp.Contains(ch))
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        mismatched += 1;
                    }

                    if (stack.Count > 0)
                    {
                        char sch = stack.Pop();

                        if (sch == '(')
                        {
                            if (ch != ')')
                            {
                                mismatched += 1;
                                if (mismatched > k) return false;
                                stack.Push(sch);
                            }
                            else
                            {
                                matched += 1;
                            }
                        }
                        else if (sch == '{')
                        {
                            if (ch != '}')
                            {
                                mismatched += 1;
                                if (mismatched > k) return false;
                                stack.Push(sch);
                            }
                            else
                            {
                                matched += 1;
                            }
                        }
                        else if (sch == '[')
                        {
                            if (ch != ']')
                            {
                                mismatched += 1;
                                if (mismatched > k) return false;
                                stack.Push(sch);
                            }
                            else
                            {
                                matched += 1;
                            }
                        }

                    }

                }
            }

            if (matched == str.Length / 2 &&  str.Length % 2 == 0) return true;

            if (mismatched == k) return true;
            else return false;

        }
        static void Main(string[] args)
        {

            var sol = new Program();

            string test1 = "(){}";
            bool result = sol.isValid(test1, 0);
            Console.WriteLine(result);

            string test2 = "([)";
            result = sol.isValid(test2, 1);
            Console.WriteLine(result);
            string test3 = "(])";
            result = sol.isValid(test3, 1);
            Console.WriteLine(result);

            string test4 = "(][())";
            result = sol.isValid(test4, 2);
            Console.WriteLine(result);

        }
    }
}
