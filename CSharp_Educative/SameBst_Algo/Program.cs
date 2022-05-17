using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SameBst_Algo
{
    class Program
    {
        //Time Complexity O(n^2) and Space Complexity O(n^2)
        public static bool IsSameBSt(List<int> arrayOne, List<int> arrayTwo)
        {
            if (arrayOne.Count != arrayTwo.Count) return false;
            if (arrayOne.Count == 0 && arrayTwo.Count == 0) return true;
            if (arrayOne[0] != arrayTwo[0]) return false;
            
            List<int> leftOne = GetSmaller(arrayOne);
            List<int> leftTwo = GetSmaller(arrayTwo);

            List<int> rightOne = GetGraterOrEqual(arrayOne);
            List<int> rightTwo = GetGraterOrEqual(arrayTwo);

            return IsSameBSt(leftOne, leftTwo) && IsSameBSt(rightOne, rightTwo);

        }

        private static List<int> GetGraterOrEqual(List<int> array)
        {
            List<int> small = new List<int>();

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] < array[0]) small.Add(array[i]);
            }

            return small;
        }

        private static List<int> GetSmaller(List<int> array)
        {
            List<int> great = new List<int>();

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] >= array[0]) great.Add(array[i]);
            }

            return great;
        }


        static void Main(string[] args)
        {

            List<int> arrayOne = new List<int> { 10, 15, 8, 12, 94, 81, 5, 2, 11 };
            List<int> arrayTwo = new List<int> { 10, 8, 5, 15, 2, 12, 11, 94, 81 };

            bool bSame = IsSameBSt(arrayOne, arrayTwo);

            Console.WriteLine(bSame);
        }
    }
}
