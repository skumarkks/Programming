using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPeak
{
    class Program
    {
        
		public static int LongestPeak(int[] array)
        {
            // Write your code here.
            int maxPeekLength = 0;

            for (int i = 1; i < array.Length-1; i++)
            {

                bool isPeek = (array[i] > array[i - 1] && array[i] > array[i + 1]);

                if (isPeek)
                {

                    int left = i - 2;
                    int right = i + 2;

                    while (left >= 0)
                    {
                        if (left >= 0 && array[left] < array[left + 1])
                        {

                            left--;
                        }
                        else
                        {
                            left++;
                            break;
                        }
                    }

                    while (right < array.Length)
                    {
                        if (array[right] < array[right - 1])
                        {
                            right++;
                        }
                        else
                        {
                            right--;
                            break;
                        }
                    }

                    int currentPeekLength = right - left + 1;
                    if (currentPeekLength > maxPeekLength)
                    {
                        maxPeekLength = currentPeekLength;
                    }

                    //i = right;
                }
            }

            return maxPeekLength;
        }
		
		static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            //int[] array = new int[] {5,4,3,2,1,2};
            int longestPeak = Program.LongestPeak(array);
            Console.WriteLine(longestPeak);
        }
    }
}
