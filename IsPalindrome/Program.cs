using System;

namespace IsPalindrome
{
    class MyList
    {
        public char val;
        public MyList Next;

        public MyList(char val)
        {
            this.val = val;
        }
    };

    class Program
    {
        public bool IsPalindrome(MyList list)
        {
            var head = list;
            // find the mid of the list
            if (head == null || head.Next == null) return false;

            var fast = head;
            var slow = head;

            while(fast != null)
            {
                fast = (fast.Next != null) ? fast.Next.Next : null;
                slow = slow.Next;
            }


            //dive the list into two halves
            var midOfList = slow;

            // reverse the 2nd half
            var previous = slow;
            var current = slow;
            var Next = slow.Next;

            while(current!= null)
            {

            }
            // compare the 1st half with 2nd half

            return false;
        }
        static void Main(string[] args)
        {
            string check = "malayalam";


            var list1 = new MyList('m');
            var list2 = new MyList('a');
            var list3 = new MyList('l');
            var list4 = new MyList('a');
            var list5 = new MyList('y');
            var list6 = new MyList('a');
            var list7 = new MyList('l');
            var list8 = new MyList('a');
            var list9 = new MyList('m');
            
            list1.Next = list2;
            list2.Next = list3;
            list3.Next = list4;
            list4.Next = list5;
            list5.Next = list6;
            list6.Next = list7;
            list7.Next = list8;
            list8.Next = list9;
            list9.Next = null;

            var prg = new Program();
            prg.IsPalindrome(list1);
            Console.WriteLine("Hello World!");
        }
    }
}
