using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_PalindromeList
{
    public class LinkedList
    {
        public string val;
        public LinkedList next;
    }

    class Program
    {
        public static bool IsPalindromeList(LinkedList li)
        {
            LinkedList list = li;
            int count = 0;
            bool isPalindrome = false;

            // loop through the list and get the length
            while (list != null)
            {
                count++;
                list = list.next;
            }

            // chek the length is even or odd
            if (count % 2 == 0)
            {
                count = count / 2;
            }
            else
            {
                count = count / 2 + 1;
            }

            //go the node at count
            int i = 1;
            list = li;

            while (count > i)
            {
                list = list.next;
                i++;
            }

            // revers the list
            LinkedList previous = null;
            LinkedList current = list;
            LinkedList next = list.next;
            i = 1;

            while (current.next != null && count > i)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                i++;
            }

            list.next = current;

            return isPalindrome;
        }

        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.val = "N";

            var l2 = new LinkedList();
            l2.val = "i";



            var l3 = new LinkedList();
            l3.val = "t";

            var l4 = new LinkedList();
            l4.val = "i";

            var l5 = new LinkedList();
            l5.val = "n";
            //var l6 = new LinkedList();
            //l6.val = 6;

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = null;
            //l6.next = null;

            IsPalindromeList(l1);
        }
    }
}
