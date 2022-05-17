using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListReverse
{
    public class Node
    {
        public int val;
        public Node next;
    }

    public class ListNode
    {
        public Node head;
        public Node tail;

        public void AddNode(int val)
        {
            if (head == null)
            {
                tail = new Node();
                tail.val = val;
                tail.next = null;
                head = tail;
            }
            else
            {
                Node temp = new Node();
                temp.val = val;
                temp.next = null;
                tail.next = temp;
                tail = temp;
            }

        }

        public Node Head
        {
            get
            {
                return head;
            }
        }

        public Node ReverseLinkedList(Node head)
        {
            if (head == null) return null;

            Node current = head;
            Node previous = null;
            Node next = null;

            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;

            }
            return previous;
        }

        public Node ReverseSubList(Node head, int p, int q)
        {
            if (head == null) return null;

            Node previous = null;
            Node current = head;

            while (current != null)
            {
                if (current.val == p) break;

                previous = current;
                current = current.next;
            }

            Node nodeBeforeStartOfSublist = previous;
            Node nodeAtStartOfSublist = current;

            Node next = null;

            while (current != null)
            {
                if (current.val != q)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }
                else
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                    break;
                }

            }

            if (nodeBeforeStartOfSublist != null)
                nodeBeforeStartOfSublist.next = previous;
            else
                head = previous;

            nodeAtStartOfSublist.next = current;

            return head;
        }

        public Node ReverseKElementsOfLinkList(Node head, int k)
        {
            if (head == null) return null;

            int count = 1;
            Node previous = null;
            Node current = head;

            while (current != null && count <= k)
            {
                Node next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                count++;
            }
            head.next = current;
            head = previous;

            return head;
        }
    }


    
    class Program
    {
        static void Main(string[] args)
        {

            ListNode first = new ListNode();

            first.AddNode(1);
            first.AddNode(2);
            first.AddNode(3);
            first.AddNode(4);
            first.AddNode(5);
            first.AddNode(6);
            first.AddNode(7);
            first.AddNode(8);

            //Node results = first.ReverseLinkedList(first.head);

            //Node results = first.ReverseSubList(first.head, 3, 6);

            Node results = first.ReverseKElementsOfLinkList(first.head, 4);

            while (results != null)
            {
                Console.WriteLine(results.val);
                results = results.next;
            }
                


        }

    }
}
