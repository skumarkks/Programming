using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_ReverseLinkList
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;
    }


    
    class Program
    {
        public static LinkedList ReverseLinkedList(LinkedList listHead, int first, int last)
        {
            LinkedList previous = null;
            LinkedList current = listHead;
            LinkedList next = current.next;

            int count = 0;

            while (count <= first)
            {
                previous = current;
                current = next;
                next = current.next;
                count++;
            }

            LinkedList firstNode = previous;
            LinkedList lastNode = current;


            while (count >= first && count <= last)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                count++;
            }

            
            firstNode.next = previous;
            lastNode.next = current.next;
            //current.next = next;
            
            return listHead;
        }

        static void Main(string[] args)
        {
            LinkedList listHead = new LinkedList();
            LinkedList listPrev = listHead;

            for(int i = 0; i <= 10; i++)
            {
                var list = new LinkedList();

                listPrev.val = i;
                listPrev.next = list;
                listPrev = list;
            }

            var listReverse = ReverseLinkedList(listHead, 3, 8);
        }
    }
}
