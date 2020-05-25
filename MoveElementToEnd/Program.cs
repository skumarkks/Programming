using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveElementToEnd
{
    class Program
    {
        public static int[] MoveElementToEnd(int[] num, int toMove)
        {
            int left = 0;
            int right = num.Length - 1;

            while (left < right)
            {
                while (left < right && num[right] == toMove)
                {
                    right--;
                }

                while (left < right && num[left] != toMove)
                {
                    left++;
                }

                swap(left, right, num);
                right--;
                left++;
            }

            return num;
        }

        public static void swap(int left, int right,int[] array)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

        }
        static void Main(string[] args)
        {
            int[] test = new int[] {2, 1, 2, 2, 2, 3, 4, 2};

            //int[] test = new int[] { 1, 2, 3, 4, 5 };
            int toMove = 2;

            int[] result = Program.MoveElementToEnd(test, toMove);

            foreach (var item in result)
            {
                Console.WriteLine("{0} ", item);
            }


        }
    }
}
