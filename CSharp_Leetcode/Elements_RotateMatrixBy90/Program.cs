using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_RotateMatrixBy90
{
    class Program
    {
        public static void RotateBy90(int[,] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n -1 - layer;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first,i];
                    matrix[first, i] = matrix[last - offset, first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = top;
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };
            RotateBy90(matrix, 4);

        }
    }
}
