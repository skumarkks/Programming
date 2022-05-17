using System;

namespace ListOperations
{
    class MyList
    {
        public int val;
        public MyList Next;

        public MyList(int val)
        {
            this.val = val;
        }
    };

    class Program
    {
        public bool SearchCycle(MyList list)
        {
            if (list == null) return false;
            MyList slow = list;
            MyList fast = list;

            while(fast != null)
            {
                fast = (fast.Next != null) ? fast.Next.Next : null;
                slow = slow.Next;

                if (fast == slow) return true;
            }
            return false;
        }

        public int FindCycleLength(MyList list)
        {

            if (list == null) return 0;
            MyList slow = list;
            MyList fast = list;

            int count = 1;
            while (fast != null)
            {
                fast = (fast.Next != null) ? fast.Next.Next : null;
                slow = slow.Next;

                if (fast == slow)
                {
                    slow = slow.Next;
                    while(fast != slow)
                    {
                        count++;
                        slow = slow.Next;
                    }
                    break;
                }
            }
            return count;
        }

        public int FindStartOfCycle(MyList list, int k)
        {
            if (list == null) return 0;

            MyList fast = list;
            MyList slow = list;

            for (int i =0; i < k; i++)
            {
                fast = fast.Next;
            }

            while(fast != slow)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow.val;
        }

        static void Main(string[] args)
        {

            var list1  = new MyList(1);
            var list2 = new MyList(2);
            var list3 = new MyList(3);
            var list4 = new MyList(4);
            var list5 = new MyList(5);
            var list6 = new MyList(6);


            list1.Next = list2;
            list2.Next = list3;
            list3.Next = list4;
            list4.Next = list5;
            list5.Next = list6;
            list6.Next = list3;

            var prg = new Program();
            bool result= prg.SearchCycle(list1);
            Console.WriteLine(result);
            int count = prg.FindCycleLength(list1);
            Console.WriteLine(count);
            var val = prg.FindStartOfCycle(list1, count);
            Console.WriteLine(val);
        }
    }
}
