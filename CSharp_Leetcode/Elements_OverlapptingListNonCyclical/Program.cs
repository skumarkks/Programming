using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_OverlapptingListNonCyclical
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;
    }

    class Program
    {
        public static bool IsOverlappingList(LinkedList l0, LinkedList l1, int l0len, int l1len)
        {
            LinkedList lmore = l0len > l1len ? l0 : l1;
            LinkedList lless = l0len < l1len ? l0 : l1;


            lmore = MoveListByKNode(out lmore, Math.Abs(l0len - l1len));

            while (lmore != null && lless != null)
            {
                lmore = lmore.next;
                lless = lless.next;
            }

            if (lmore == null && lless == null)
                return true;
            return false;
        }

        public static LinkedList MoveListByKNode(out LinkedList l, int k)
        {
            LinkedList kj = l;

            while (--k < 0)
            {
                l = kj.next;
            }

            l = kj;
            return l;
        }

        static void Main(string[] args)
        {
        }
    }
}
