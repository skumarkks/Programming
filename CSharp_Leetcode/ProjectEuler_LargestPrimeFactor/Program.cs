using System;

namespace ProjectEuler_LargestPrimeFactor
{
    public class PrintFactor
    {
        public ulong maxPrime;
        public ulong FindLargestPrime(ulong n)
        {
            ulong lastPrime = n;
            lastPrime = FindNextPrime(lastPrime);

            while (n % lastPrime != 0)
            {
                lastPrime = FindNextPrime(lastPrime);
            }
            
            return lastPrime;
        }

        public ulong FindNextPrime(ulong LastPrime)
        {
            ulong i = LastPrime;
            while (i != 0)
            {
                i--;
                if (i == 3) return i;
                if (i == 5) return i;
                if (i % 2 == 0 || i % 3 == 0  || i % 5 == 0 )
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("prime {0}", i);
                    return i;
                }
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prm = new PrintFactor();
            ulong result = prm.FindLargestPrime(600851475143);
            Console.WriteLine(result);
        }
    }
}
