using System;

namespace ClosestPair
{
    public class ClosestPair
    {
        int[] FindClosestPair(int[] x, int[] y)
        {
            if (x.Length == 0 && y.Length == 0)
                return new int[] { };

            int xLen = x.Length - 1;
            int yLen = y.Length - 1;

            int i = 0;
            int j = 0;

            int xIndex = -1;
            int yIndex = -1;

            int closest = Int32.MaxValue;

            while (i <= xLen && j <= yLen)
            {
                int currentClosest = closest;
                closest = Math.Min(closest, Math.Abs(x[i] - y[j]));

                if (currentClosest != closest)
                {
                    xIndex = i;
                    yIndex = j;
                }

                if (x[i] == y[j])
                {
                    return new int[] { x[xIndex], y[yIndex]};
                }
                else if (x[i] < y[j])
                {
                    i++;
                }
                else if (x[i] > y[j])
                {
                    j++;
                }
            }
            if (xIndex == -1 && yIndex == -1)
                return new int[] { };

            return new int[] { x[xIndex], y[yIndex]};
        }

        static void Main(string[] args)
        {
            var test = new ClosestPair();
            var x = new int[] { -1, 5, 10, 20, 28, 3 };
            var y = new int[] { 26, 134, 135, 15, 17 };
            var pair = test.FindClosestPair(x, y);
            int[] expected = new int[] { 28, 26 };

            for (int i = 0; i < pair.Length; i++)
            {
                Console.Write("{0} ", pair[i]);
            }
        }
    }

}
