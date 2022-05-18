using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_EvenOddMergeList
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;
    }
    class Program
    {

        public static LinkedList EvenOddMergeList(LinkedList li)
        {
            if (li == null || li.next == null)
                return li;
            // create temp list nodes
            LinkedList evenHead = null;
            LinkedList evenCurrent = null;
            LinkedList oddHead = null;
            LinkedList oddCurrent = null;
            LinkedList resultList = null;

            // assign the current node to head of the given list
            var current = li;

            // Loop theoruhg the list of n items
            while (current != null)
            {
                // if the node is even or odd
                if (current.val % 2 == 0)
                {
                    if (evenHead == null)
                    {
                        evenHead = current;
                        evenCurrent = current;
                        current = current.next;
                    }
                    else
                    {
                        evenCurrent.next = current;
                        evenCurrent = current;
                        current = current.next;
                    }

                }
                else
                {
                    if (oddHead == null)
                    {
                        oddHead = current;
                        oddCurrent = current;
                        current = current.next;

                    }
                    else
                    {
                        
                        oddCurrent.next = current;
                        oddCurrent = current;
                        current = current.next;
                    }
                }
            }

            if (evenCurrent != null) evenCurrent.next = null;
            if (oddCurrent != null) oddCurrent.next = null;

            
            // if even and odd node exist
            if (evenHead != null && oddHead != null)
            {
                resultList = evenHead;
                evenCurrent.next = oddHead;
            }

            // if even or odd node only exist
            if (evenHead == null || oddHead == null)
            {
                if (evenHead == null)
                    resultList = oddHead;
                if (oddHead == null)
                {
                    resultList = evenHead;
                }
            }



            return resultList;

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
            l6.next = null;
           var result =  EvenOddMergeList(l1);
            
        }
    }
}
