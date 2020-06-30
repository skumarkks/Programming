using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateSubSequence
{
    class Program
    {
        //Time Complexity O(n) and space complexity O(1)
        public static bool ValidateSubSequence(int[] num, int[] sequence)
        {
            if (num.Length == 0 || sequence.Length == 0) return false;
            if (num.Length < sequence.Length) return false;

            int numIdx = 0;
            int sequenceIdx = 0;

            bool isValid = false;

            while (numIdx < num.Length && sequenceIdx < sequence.Length)
            {
                if (num[numIdx] == sequence[sequenceIdx])
                {
                    sequenceIdx++;
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

                numIdx++;
            }

            return isValid && sequenceIdx == sequence.Length;
        }

        static void Main(string[] args)
        {
            int[] num = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            int[] sequence = new int[] { 1, 6, -1, 10 };

            bool result = Program.ValidateSubSequence(num, sequence);

            Console.WriteLine(result == true ? "Pass" : "Fail");
        }
    }
}
