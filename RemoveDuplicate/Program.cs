using System;

namespace RemoveDuplicate
{
	public class DuplicateRemoval
    {
        public static int FindAndRemoveDuplicate(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int start = 0;
            int end = 1;
            while (end < arr.Length)
            {
                int dif = arr[end] - arr[start];
                if (dif != 0)
                {
                    start++;
                    swap(arr, start, end);
                    end++;
                }
                else if (dif == 0)
                {
                    end++;
                }
            }

            return start+1;
        }

        private static void swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }

        public static int FindRemoveDuplicate1(int[] arr, int key)
        {
            if (arr.Length == 0) return 0;

            int nextElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != key)
                {
                    arr[nextElement] = arr[i];
                    nextElement++;
                }
            }

            return nextElement + 1;

        }

        public static void Main(string[] args)
        {
            int[] test1 = new int[] { 2, 3, 3, 4, 5, 5, 6 };
            int actualResult = 5;
            int expectedResult = DuplicateRemoval.FindAndRemoveDuplicate(test1);
            Console.WriteLine(actualResult == expectedResult ? "Pass" : "Fail");

            int[] test2 = new int[] { 3, 3, 3 };
            actualResult = 1;
            expectedResult = DuplicateRemoval.FindAndRemoveDuplicate(test2);
            Console.WriteLine(actualResult == expectedResult ? "Pass" : "Fail");

            int[] test3 = new int[] {3, 2, 3, 6, 3, 10, 9, 3};
            actualResult = 5;
            expectedResult = DuplicateRemoval.FindRemoveDuplicate1(test3, test3[0]);
            Console.WriteLine(actualResult == expectedResult ? "Pass" : "Fail");
        }
    }

}
