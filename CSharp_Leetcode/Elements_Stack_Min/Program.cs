using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_Stack_Min
{
    public class NewStack
    {
        public int top = -1;
        public int topMax = -1;
        public int topMin = -1;

        int[] stackBase = new int[500];
        int[] stackMinStag = new int[500];
        int[] stackMaxStag = new int[500];
        
        public void Push(int val)
        {
            if (top < 500)
            {
                stackBase[++top] = val;

                if (topMax == -1)
                {
                    stackMaxStag[++topMax] = val;
                }
                else
                {
                    if (stackMaxStag[topMax] < val)
                    {
                        stackMaxStag[++topMax] = val;
                    }
                }

                if (topMin == -1)
                {
                    stackMinStag[++topMin] = val;
                }
                else
                {
                    if (stackMinStag[topMin] > val)
                    {
                        stackMinStag[++topMin] = val;
                    }
                }

            }
            else
            {
                throw new Exception("Stack Full");
            }
        }

        public int Pop()
        {
            int ret = stackBase[top];
            top--;

            if (stackMinStag[topMin] == ret)
            {
                topMin--;
            }

            if (stackMaxStag[topMax] == ret)
            {
                topMax--;
            }

            return ret;

        }

        public int  Min()
        {
            return stackMinStag[topMin];
        }

        public int Max()
        {
            return stackMaxStag[topMax];
        }

    }
    
    class Program
    {

        
        static void Main(string[] args)
        {
            NewStack nStack = new NewStack();
            nStack.Push(50);
            nStack.Push(40);
            nStack.Push(35);
            nStack.Push(55);
            nStack.Push(37);
            nStack.Push(30);
            nStack.Push(20);
           
            Console.WriteLine(nStack.Max());
            Console.WriteLine(nStack.Min());

            nStack.Pop();
            nStack.Pop();

            Console.WriteLine(nStack.Max());
            Console.WriteLine(nStack.Min());
            
            nStack.Push(1);
            nStack.Push(100);
            Console.WriteLine(nStack.Max());
            Console.WriteLine(nStack.Min());
        }
    }
}
