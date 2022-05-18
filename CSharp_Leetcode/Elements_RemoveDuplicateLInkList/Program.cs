using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_RemoveDuplicateLInkList
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;
    }

    class Program
    {
        public static LinkedList RemoveDuplicate(LinkedList li)
        {
            // check if the li is not null
            if(li == null || li.next == null)
            {
                return li;
            }
            // Use a distinct and iteration node
            var distinctNode = li;
            var iterNode = li.next;

            // iterate through the linklist
            while (iterNode != null)
            {
                // if the duplicate iterate through all the duplicate and rearrange the pointer
                // else advance through the list
                if (distinctNode.val == iterNode.val)
                {
                    iterNode = iterNode.next;
                    while (distinctNode.val == iterNode.val)
                    {
                        iterNode = iterNode.next;
                    }

                    distinctNode.next = iterNode;
                    distinctNode = iterNode;
                    if (distinctNode.next == null)
                        break;
                }
                else
                {
                    distinctNode = distinctNode.next;
                    iterNode = iterNode.next;
                }
            }
            return li;
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
            l4.val = 3;

            var l5 = new LinkedList();
            l5.val = 3;
            var l6 = new LinkedList();
            l6.val = 6;

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            l6.next = null;

            l1 = RemoveDuplicate(l1);
        }
    }
}
