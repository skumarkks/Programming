using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IsWellFormedString
{
    class Program
    {
        public static bool IsWellFormedString(string inString)
        {
            // if the instring is null or empty return false
            if(string.IsNullOrEmpty(inString))
            {
                return false;
            }

            // define the keys
            char[] key = {'(', ')'};
            Stack<char> stack = new Stack<char>();

            // get the value from the string array and compare with the key
            // if the key is in the key list  push to stack
            // if the string a closed string then pop the string 
            foreach (char ch in inString)
            {
                if (key.Contains(ch))
                {
                    if (ch == ')' && stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(ch);
                    }
                }
            }

            if (stack.Count == 0)
                return true;
            else
            {
                return false;
            }

            return false;
        }
        static void Main(string[] args)
        {
            bool result = Program.IsWellFormedString("(sur)esh)");
        }
    }
}
