using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_MaximalRectangle_85
{
    class Program
    {
        public static int FindMaximumRectangleArea(char[,] matrix)
        {
            int[,] widthArray = new int[matrix.GetLength(0),matrix.GetLength(1)];

            int rowLength = matrix.GetLength(0) - 1;
            int colLength = matrix.GetLength(1) - 1;
            int width = 0;
            int maxArea = Int32.MinValue;

            for (int i = 0; i <= rowLength; i++)
            {
                
                for (int j = 0; j <= colLength; j++)
                {
                    if (matrix[i,j] == '1')
                    {
                        widthArray[i, j] = (j == 0 ? 1: widthArray[i, j - 1] + 1);

                        width = widthArray[i, j];

                        for (int k = i; k >= 0; k--)
                        {
                            width = Math.Min(width, widthArray[k, i]);
                            maxArea = Math.Max(maxArea, width * (i - k + 1));
                        }

                    }
                    
                }
            }

            return maxArea;
        }


        static void Main(string[] args)
        {
            char[,] matrix =
            {
                { '1','0','1','0','0' },
                { '1','0','1','1','1' },
                { '1','1','1','1','1' },
                { '1','0','0','1','0' }
            };

            int maxArea = Program.FindMaximumRectangleArea(matrix);
            //int maxArea = Program.MaximalRectangle(matrix);
            Console.WriteLine(maxArea);

        }
    }
}
