using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_AddNumber_2
{
    /**
 * Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Store in temporary store
            var la = l1;
            var lb = l2;

            // check for corener cases
            if (la == null && lb == null)
                return null;
            if (la == null && lb != null)
                return lb;
            if (la != null && lb == null)
                return la;

            // for result and list travel
            ListNode lResult = null;
            ListNode IPrevious = null;

            // for list travel
            int first = 0;
            // for carry
            int carry = 0;

            while (la != null || lb != null)
            {

                int x = (la != null) ? la.val : 0;
                int y = (lb != null) ? lb.val : 0;

                int s = carry + x + y;

                int result = s % 10;
                carry = s / 10;

                ListNode lCurrent = new ListNode(result);
                if (first == 0)
                {
                    lResult = lCurrent;
                    IPrevious = lCurrent;
                    first++;
                }
                else
                {
                    IPrevious.next = lCurrent;
                    IPrevious = lCurrent;
                }

                la = (la != null) ? la.next : null;
                lb = (lb != null) ? lb.next : null;
            }

            if (carry != 0)
            {
                ListNode lCurrent = new ListNode(carry);
                IPrevious.next = lCurrent;
                IPrevious = lCurrent;

            }

            return lResult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(4);
            ListNode l12 = new ListNode(5);
            l1.next = l12;
            ListNode l13 = new ListNode(9);
            l12.next = l13;

            ListNode l2 = new ListNode(9);
            ListNode l22 = new ListNode(4);
            l2.next = l22;
            //ListNode l23 = new ListNode(5);
            //l22.next = l23;

            var sol = new Solution();
            var lResult = sol.AddTwoNumbers(l1, l2);

            while (lResult != null)
            {
                Console.WriteLine(lResult.val);
                lResult = lResult.next;
            }
        }
    }
}
