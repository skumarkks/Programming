using System;

namespace DoublelyLinkedList
{
    public class Node
    {
        public int val;
        public Node PreviousNode;
        public Node NextNode;
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;
        public Node nodes;

        /*public Node CreateNodes(LinkedList list, int val)
        {
            Node temp = new Node();
            temp.val = val;
            temp.PreviousNode = null;
            temp.NextNode = null;

            if (list.nodes == null)
            {
                if (list.head == null)
                    list.head = temp;
                if (list.tail == null)
                    list.tail = temp;
            }

            list.nodes = temp;

            while (list == null)
            {

            }
            
        }*/
    }
    class Program
    {
        LinkedList lnList = new LinkedList();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
