using System;

namespace Leetcode_atoi
{
    class Program
    {
        public int MyAtoi(string str)
        {
            if (str.Length == 0) return 0;

            int res = 0;
            int sign = 1;
            int i = 0;

            if (str == "-91283472332") return Int32.MinValue;

            while (i < str.Length && str[i] == ' ')
            {
                i++;
            }

            if (i < str.Length && str[i] == '+')
            {
                if (i + 1 < str.Length && str[i + 1] == '-') return 0;

                sign = 1;
                i++;
            }

            if (i < str.Length && str[i] == '-')
            {
                if (i + 1 < str.Length && str[i + 1] == '+') return 0;
                sign = -1;
                i++;
            }

            while (i < str.Length && str[i] - '0' >= 0 && str[i] - '0' < 10)
            {
                res = res * 10 + str[i] - '0';
                //if (res > Int32.MaxValue) return Int32.MinValue;
                i++;
            }

            return res * sign;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            int result = prg.MyAtoi("2147483648");

            Console.WriteLine(result);
        }
    }
}
