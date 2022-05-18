using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2_AddTwoNumber
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l1Current = l1;
            ListNode l2Current = l2;
            ListNode l3Result = null;
            ListNode l3NextResult = null;

            int sum = 0;
            int carry = 0; ;

            while(l1Current != null || l2Current != null)
            {
                var val1 = l1Current?.val ?? 0;
                var val2 = l2Current?.val ?? 0;

                sum = val1 + val2 + carry;

                if (sum >= 10)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }

                if(l3Result == null)
                {
                    l3Result = new ListNode(sum);
                    l3NextResult = l3Result;
                }
                else
                {
                    var l3TempResult = new ListNode(sum);
                    l3NextResult.next = l3TempResult;
                    l3NextResult = l3TempResult;
                }

                l1Current = l1Current?.next;
                l2Current = l2Current?.next;
            }
            return l3Result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            ListNode l1pre = l1;

            ListNode l1temp = new ListNode(4);
            l1pre.next = l1temp;
            l1pre = l1temp;

            l1temp = new ListNode(3);
            l1pre.next = l1temp;
            l1pre = l1temp;

            ListNode l2 = new ListNode(5);
            ListNode l2pre = l2;

            ListNode l2temp = new ListNode(6);
            l2pre.next = l2temp;
            l2pre = l2temp;

            l2temp = new ListNode(4);
            l2pre.next = l2temp;
            l2pre = l2temp;

            var lresult = Solution.AddTwoNumbers(l1, l2);
            
        }
    }
}
