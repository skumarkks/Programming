using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elements_IsCyclicalList
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;
    }

    class Program
    {
        public static LinkedList StartOfLinkListCycle(LinkedList Head)
        {
            bool isCyclicalList = false;
            int LengthOfCycle = 0;

            if (Head == null)
            {
                LengthOfCycle = 0;
            }

            // Slowiterator move by one and fastIterator moves by two
            var slowIterator = Head.next;
            var fastIterator = Head.next.next;

            while (slowIterator != null || fastIterator != null)
            {
                if (slowIterator == fastIterator)
                {
                    LengthOfCycle = 0;
                    isCyclicalList = true;
                    break;
                }
                else
                {
                    if (slowIterator != null)
                    {
                        slowIterator = slowIterator.next;
                    }

                    if (fastIterator != null)
                    {
                        if (fastIterator.next != null)
                        {
                            fastIterator = fastIterator.next.next;
                        }
                    }
                    else
                    {
                        LengthOfCycle = 0;
                        isCyclicalList = false;
                    }
                }
            }

            LinkedList previousNode = null;

            if (isCyclicalList)
            {
                slowIterator = Head.next;
                previousNode = fastIterator;
                fastIterator = fastIterator.next;

                int count = 0;

                while (true)
                {
                    // when equal that is the start of the node
                    if (slowIterator == fastIterator)
                    {
                        previousNode.next = null;
                        return slowIterator;
                    }
                    else
                    {
                        previousNode = fastIterator;
                        slowIterator = slowIterator.next;
                        fastIterator = fastIterator.next;
                        Console.WriteLine(count++);
                    }
                }
            }

            return null;
        }

        public static bool IsCyclicalList(LinkedList Head, out int LengthOfCycle)
        {
            bool isCyclicalList = false;

            if (Head == null)
            {
                LengthOfCycle = 0;
                return isCyclicalList;
            }

            // Slowiterator move by one and fastIterator moves by two
            var slowIterator = Head.next;
            var fastIterator = Head.next.next;

            while (slowIterator != null || fastIterator != null)
            {
                if (slowIterator == fastIterator)
                {
                    LengthOfCycle = 0;
                    isCyclicalList = true;
                    break;
                }
                else
                {
                    if (slowIterator != null)
                    {
                        slowIterator = slowIterator.next;
                    }

                    if (fastIterator != null) 
                    {
                        if (fastIterator.next != null)
                        {
                            fastIterator = fastIterator.next.next;
                        }
                    }
                    else
                    {
                        LengthOfCycle = 0;
                        isCyclicalList = false;
                    }
                }
            }

            int count = 0;

            //If there is a cycle, count the number of nodes from where the cycle is detected.
            if (isCyclicalList)
            {
                fastIterator = fastIterator.next;

                count = 1;

                // set the slowiterator and move the fastiterator
                // and iterate till the fastiteror meet the slowiterator
                while (slowIterator != fastIterator)
                {
                    fastIterator = fastIterator.next;
                    count++;
                }
            }

            //If there is a cycle what is the start of the node of the cycle


            LengthOfCycle = count;
            return isCyclicalList;
        }

        

        static void Main(string[] args)
        {

            LinkedList l1 = new LinkedList();
            l1.val = 1;

            var l2 = new LinkedList();
            l2.val = 2;

            

            var l3 = new LinkedList();
            l3.val = 3;

            var l4 = new LinkedList();
            l4.val = 4;

            var l5 = new LinkedList();
            l5.val = 5;
            var l6 = new LinkedList();
            l6.val = 6;

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            l6.next = l3;

            int lengthOfCycle = 0;

            bool isCyclic = IsCyclicalList(l1, out lengthOfCycle);
            LinkedList list = StartOfLinkListCycle(l1);
        }
    }
}
