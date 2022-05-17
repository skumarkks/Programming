using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimumInStream
{
    public class NumberOperation
    {
        public Stack<int> valueStack = new Stack<int>();
        public Stack<int> minStack = new Stack<int>();
        
        public void Add(int value)
        {
            valueStack.Push(value);

            if(minStack.Count == 0)
                minStack.Push(value);

            if (minStack.Count > 0 && minStack.Peek() >= value)
            {
                minStack.Push(value);
            }
        }

        public void Remove()
        {
            int value = valueStack.Pop();

            if (minStack.Count > 0 && minStack.Peek() == value)
            {
                minStack.Pop();
            }
        }

        public int FindMinimum()
        {
            return minStack.Peek();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {6, 7, 8, 3, 4, 2, 8, -1, 10};

            var sol = new NumberOperation();
            sol.Add(nums[0]);
            sol.Add(nums[1]);
            sol.Add(nums[2]);
            sol.Add(nums[3]);
            sol.Add(nums[4]);
            sol.Add(nums[5]);
            sol.Add(nums[6]);
            sol.Add(nums[7]);
            sol.Add(nums[8]);
            Console.WriteLine(sol.FindMinimum());
            sol.Remove();
            sol.Remove();
            sol.Remove();
            Console.WriteLine(sol.FindMinimum());
            sol.Remove();
            sol.Remove();
            Console.WriteLine(sol.FindMinimum());

        }
    }
}
