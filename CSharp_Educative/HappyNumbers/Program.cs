using System;

namespace HappyNumbers
{
    class Program
    {

        public bool IsHappyNumber(int num)
        {
            int slow = num;
            int fast = num;

            do
            {
                slow = FindSumNumber(slow);
                fast = FindSumNumber(FindSumNumber(fast));
            } while (slow != fast);

            return slow == 1;
        }

        public int FindSumNumber(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num = num / 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            //bool bResult = prg.IsHappyNumber(23);
            bool bResult = prg.IsHappyNumber(12);

            Console.WriteLine(bResult);
        }
    }
}
