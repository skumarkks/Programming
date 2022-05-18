using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_TwoSum
{
    class Program
    {

        public static int[] TwoSum(int[] numbers, int target)
        {
            var numDictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int difference = target - numbers[i];
                
                if(numDictionary.ContainsKey(difference) && numbers[i] != target)
                {
                    int[] result = { i+1, numDictionary[difference]+1 };
                    return result;
                }
                else
                {
                    if (!numDictionary.ContainsKey(numbers[i]))
                    {
                        numDictionary.Add(numbers[i], i);
                    }
                }
            }
            return null;
        }
        static void Main(string[] args)
        {

            int[] numbers = { 2, 2, 11, 15 };
            int target = 17;
            int[] result = TwoSum(numbers, target);
            if (result != null)
            {
                foreach (var index in result)
                {
                    Console.WriteLine(index);

                }
            }
            else
            {
                Console.WriteLine("nothing");
            }
    }
    }
}
