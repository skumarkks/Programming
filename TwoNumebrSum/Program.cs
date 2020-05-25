using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumebrSum
{
    public class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.

            if (array.Length == 1) return null;

            Dictionary<int, int> numberMap = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int dif = targetSum - array[i];

                if (numberMap.ContainsKey(dif))
                {
                    return new int[] { array[i], dif };
                }
                else
                {
                    if (!numberMap.ContainsKey(array[i]))
                    {
                        numberMap.Add(array[i], i);
                    }
                }
            }


            return null;
        }

        static void Main(string[] args)
        {
            int[] test1 = new int[] { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 };
            int[] result = Program.TwoNumberSum(test1, 164);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
	
}
