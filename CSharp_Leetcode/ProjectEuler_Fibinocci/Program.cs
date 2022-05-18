using System;
using System.Collections.Generic;

namespace ProjectEuler_Fibinocci
{
    public class Fibonacci
    {
        public Dictionary<ulong,ulong> fibnoDictionary = new Dictionary<ulong, ulong>();
        public ulong FindFibonacci(ulong n)
        {
            try
            {
                if (n == 1 || n == 2)
                {
                    if (!fibnoDictionary.ContainsKey(n))
                        fibnoDictionary.Add(n, 1);
                    return 1;
                }
                else
                {
                    ulong fibn1, fibn2;

                    //fib(n) = fib(n-1) + fib(n-2)

                    fibn1 = fibnoDictionary[n - 1];
                    fibn2 = fibnoDictionary[n - 2];
                    ulong fibn = fibn1 + fibn2;

                    if (!fibnoDictionary.ContainsKey(n))
                        fibnoDictionary.Add(n, fibn);

                    return fibn;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return 0;
        }

        public ulong FindFinonacciEvenSum(ulong n)
        {
            ulong result = 0;
            ulong i = 1;
            ulong sum = 0;
            while (result <= 4000000)
            {
                result = FindFibonacci(i);
                Console.Write(".");
                if (result % 2 == 0)
                    sum += result;
                i++;
            }
            Console.WriteLine(sum);
            return sum;            
        }


        class Program
        {
            static void Main(string[] args)
            {
                var fib = new Fibonacci();
                ulong result = fib.FindFinonacciEvenSum(4000000);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
