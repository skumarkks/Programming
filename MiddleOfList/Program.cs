using System;

namespace MiddleOfList
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
        public int FindListMiddle(MyList list)
        {
            if (list == null) return 0;
            if (list.Next == null) return 1;

            var fast = list;
            var slow = list;

            while(fast != null)
            {
                if(fast.Next == null)
                {
                    return slow.val;
                }
                else
                {
                    fast = fast.Next.Next;
                    slow = slow.Next;
                }
            }

            return slow.val;            
        }
        static void Main(string[] args)
        {
            var list1 = new MyList(1);
            var list2 = new MyList(2);
            var list3 = new MyList(3);
            var list4 = new MyList(4);
            var list5 = new MyList(5);
            var list6 = new MyList(6);


            list1.Next = list2;
            list2.Next = list3;
            list3.Next = list4;
            list4.Next = list5;
            list5.Next = list6; ;
            list6.Next = null; ;

            var prg = new Program();
            int val= prg.FindListMiddle(list1);

            Console.WriteLine("Hello World!");
        }
    }
}
