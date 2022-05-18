using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_CyclicallyRightShiftList
{public class LinkedList
    {
        public int val;
        public LinkedList next;
    }
    class Program
    {
        public static LinkedList CyclicallyRightShiftList(LinkedList li, uint k)
        {
            // if li is null or a sigle node return the list
            if (li == null || li.next == null)
                return li;
            // declare p (previous) and q (move to kth node)
            var head = li;
            var p = li;
            var q = li.next;
            
            // start counter to 1 since one movement is already occured
            int i = 1;

            // move to the kth node
            while (i < k-1)
            {
                p = q;
                q = q.next;
                i++;
            }
            // put the (k-1)th node to null
            p.next = null;

            // q forms the new head
            var newHead = q;

            // q node move to the tail 
            while (q.next != null)
            {
                q = q.next;
            }

            // tail is assigned as the new head 
            q.next = head;

            return newHead;

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

            CyclicallyRightShiftList(l1, 3);
        }
    }
}
