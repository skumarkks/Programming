using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraversal
{
    class Program
    {
        public static List<int> SpiralTraverse(int[,] array)
        {
            int startRow = 0;
            int endRow = array.GetLength(0)-1;
            int startCol = 0;
            int endCol = array.GetLength(1)-1;

            List<int> result = new List<int>();

            while (startRow <= endRow && startCol <= endCol)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    result.Add(array[startRow, col]);
                }

                for (int row = startRow+1; row <= endRow; row++)
                {
                    result.Add(array[row, endCol]);
                }

                for (int col = endCol-1; col >= startCol; col--)
                {
                    if (startRow == endRow) break;
                    result.Add(array[endRow, col]);
                }

                for (int row = endRow-1; row >= startRow+1; row--)
                {
                    if (startCol == endCol) break;
                    result.Add(array[row,startCol]);
                }

                startRow++;
                endRow--;
                startCol++;
                endCol--;
            }

            return result;

        }

        static void Main(string[] args)
        {
            int[,] test1  = new int[,]
            {
                {1,2,3,4},
                {12,13,14,5},
                {11,16,15,6},
                {10,9,8,7}
            };

            List<int> result = Program.SpiralTraverse(test1);

            foreach (var item in result)
            {
                Console.Write("{0} ",item);
            }
        }
    }
}
