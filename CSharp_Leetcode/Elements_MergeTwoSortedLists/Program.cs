using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elements_MergeTwoSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public ListNode()
        {
            
        }
    }
    
    class Program
    {
        public static ListNode MergeTwoSortedLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            if (l1 == null)
                return l2;

            if (l2 == null) 
                return l1;

            ListNode node1 = l1;
            ListNode node2 = l2;

            ListNode resultHead = new ListNode();
            ListNode resultTail = resultHead;

            while (node1 != null && node2 != null)
            {
                if (node1.val <= node2.val)
                {
                    resultTail.next = node1;
                    resultTail = node1;
                    node1 = node1.next;
                }
                else
                {
                    resultTail.next = node2;
                    resultTail = node2;
                    node2 = node2.next;
                }
            }

            resultTail.next = node1 ?? node2;

            return resultHead.next;
        }
        
        static void Main(string[] args)
        {
            var listnode1 = new ListNode(2);
            var listnode12 = new ListNode(5);
            var listnode13 = new ListNode(7);
            listnode1.next = listnode12;
            listnode12.next = listnode13;
            listnode13.next = null;

            var listnode2 = new ListNode(3);
            var listnode21 = new ListNode(3);
            listnode2.next = listnode21;
            listnode21.next = null;

            MergeTwoSortedLists(listnode1, listnode2);



        }
    }
}
