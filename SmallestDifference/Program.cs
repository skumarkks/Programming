using System;

namespace SmallestDifference
{
    public class Program
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            if (arrayOne.Length == 0 || arrayTwo.Length == 0) return null;

            int[] result = new int[2];
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int left = 0;
            int right = 0;
            int minimum = Int32.MaxValue;

            while (left < arrayOne.Length && right < arrayTwo.Length)
            {
                int dif = Math.Abs(arrayOne[left] - arrayTwo[right]);
                int curdif = minimum;
                minimum = Math.Min(minimum, dif);
                if (minimum != curdif)
                {
                    result[0] = arrayOne[left];
                    result[1] = arrayTwo[right];
                }
                if (arrayOne[left] < arrayTwo[right])
                {
                    left++;
                }
                else if (arrayOne[left] > arrayTwo[right])
                {
                    right++;
                }
                else if (arrayOne[left] == arrayTwo[right])
                {
                    return result;
                }
            }

            return result;
        }
        public static void Main(string[] args)
        {
            int[] arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
            int[] arrayTwo = new int[] { 26, 134, 135, 15, 17 };

            var result = Program.SmallestDifference(arrayOne, arrayTwo);


        }
    }

}
