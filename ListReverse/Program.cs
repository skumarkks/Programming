using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReverse
{
    public class LinkedList
    {
        public int value;
        public LinkedList next;
        public LinkedList(int val)
        {
            value = val;
            next = null;
        }
    }

    class Program
    {

        public static LinkedList MergeLinkedLists(LinkedList headOne, LinkedList headTwo)
        {
            // Write your code here.

            if (headOne == null && headTwo == null) return null;
            if (headOne == null && headTwo != null) return headTwo;
            if (headOne != null && headTwo == null) return headOne;

            LinkedList i = headOne;
            LinkedList j = headTwo;

            LinkedList iNext = null;
            LinkedList iPrevious = null;

            LinkedList jNext = null;
            LinkedList jPrevious = null;

            LinkedList mergeList = null;
            bool blisti = false;
            bool blistj = false;

            while (i != null && j != null)
            {
                if (i.value <= j.value)
                {
                    if (mergeList == null && i == headOne)
                    {
                        mergeList = i;
                        blisti = true;
                    }
                    iPrevious = i;
                    iNext = i.next;

                    if (blisti == false)
                    {
                        i.next = j;
                    }
                    else
                    {
                        i = i.next;
                    }
                    blisti = true;
                    blistj = false;
                }
                else if (i.value > j.value)
                {
                    if (mergeList == null && j == headTwo)
                    {
                        mergeList = j;
                        blistj = true;
                    }
                    jPrevious = j;
                    jNext = j.next;
                    if (blistj == false)
                    { 
                        j.next = i;
                    }
                    else
                    {
                        j = j.next;
                    }

                    j = jNext;

                    blisti = false;
                    blistj = true;
                } 
            }

            if (i != null)
            {
                jPrevious.next = i;
            }
            if (j != null)
            {
                iPrevious.next = j;
            }


            return mergeList;
        }

        public static LinkedList ReverseSubList(LinkedList root, int p, int q)
        {
            if (root == null) return null;

            LinkedList previousToP = null;
            LinkedList current = root;

            int count = 1;
            while(count < p && current != null)
            {
                previousToP = current;
                current = current.next;
                count++;
            }

            LinkedList p1 = current;
            LinkedList p2 = (p1.next != null) ? p1.next : null;

            while(count < q && p1 != null && p2 != null)
            {
                LinkedList temp = p2.next;
                p2.next = p1;
                count++;

                p1 = p2;
                p2 = temp;
            }

            previousToP.next = p1;
            current.next = p2;

            return root;
        }

        public static LinkedList ReverseAlternate(LinkedList head)
        {
            if (head == null) return null;

            LinkedList p1 = head;
            LinkedList p2 = (p1 != null && p1.next != null) ? p1.next : null;
            LinkedList p3 = (p2!= null && p2.next != null) ? p2.next : null;
            LinkedList p4 = (p3!= null && p3.next != null) ? p3.next : null;

            while(p1 != null & p2 != null && p3 != null )
            {
                p1.next = p3;
                p2.next = p4;
                p3.next = p2;

                p1 = (p4 != null) ? p4 : null;
                p2 = (p1!= null && p1.next != null) ? p1.next : null;
                p3 = (p2!=null && p2.next != null) ? p2.next : null;
                p4 = (p3!=null && p3.next != null) ? p3.next : null;

            }

            return head;

        }
        public static LinkedList Reverse(LinkedList head)
        {
            if (head == null) return null;

            LinkedList p1 = null;
            LinkedList p2 = head;
            LinkedList p3 = null;
            while (p2 != null)
            {
                p3 = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p3;
            }
            return p1;
        }
        static void Main(string[] args)
        {
            var node1 = new LinkedList(2);
            var node2 = new LinkedList(6);
            node1.next = node2;

            var node3 = new LinkedList(7);
            node2.next = node3;
            var node4 = new LinkedList(8);
            node3.next = node4;

            var node5 = new LinkedList(1);
            //node4.next = node5;
            var node6 = new LinkedList(3);
            node5.next = node6;

            var node7 = new LinkedList(4);
            node6.next = node7;
            var node8 = new LinkedList(5);
            node7.next = node8;

            var node9 = new LinkedList(9);
            node8.next = node9;

            var node10 = new LinkedList(10);
            node9.next = node10;


            /*
            var result = Program.Reverse(node1);
            var result = Program.ReverseAlternate(node1);

            var result = Program.ReverseSubList(node1, 3, 6);

            while (result != null)
            {
                Console.WriteLine(result.value);
                result = result.next;
            }
            */

            var result = Program.MergeLinkedLists(node1, node5);

            while (result != null)
            {
                Console.WriteLine(result.value);
                result = result.next;
            }
        }
    }
}
