using System;
using System.Collections.Generic;

namespace FruitBacket
{
    public class fruit
    {
        public int MaxTwoFruitBasket(char[] fruits)
        {
            if (fruits.Length == 0) return 0;
            if (fruits.Length == 1) return 1;

            int start = 0;
            int end = 0;

            int maxFruits = Int32.MinValue;

            var fruitMap = new Dictionary<char, int>();

            while (end < fruits.Length)
            {
                if (fruitMap.ContainsKey(fruits[end]))
                {
                    fruitMap[fruits[end]] += 1;
                }
                else
                {
                    fruitMap.Add(fruits[end], 1);
                }

                if (fruitMap.Count == 2)
                {
                    maxFruits = Math.Max(maxFruits, end - start + 1);
                }

                while (fruitMap.Count > 2)
                {
                    fruitMap[fruits[start]] -= 1;
                    if (fruitMap[fruits[start]] == 0)
                    {
                        fruitMap.Remove(fruits[start]);
                    }
                    start++;
                }
                end++;
            }
            return maxFruits;
        }

        static void Main(string[] Args)
        {
            var test = new fruit();
            char[] fruits = new char[] { 'a', 'b', 'c', 'a', 'c' };
            int result = test.MaxTwoFruitBasket(fruits);
            int expected = 3;
            if (result == expected)
            {
                Console.Write("Passed:  {0}", result);
            }
            else
            {
                Console.Write("Failed");
            }
            Console.WriteLine();
            fruits = new char[] { 'a', 'b', 'c', 'b', 'b' };
            result = test.MaxTwoFruitBasket(fruits);
            expected = 4;
            if (result == expected)
            {
                Console.Write("Passed: {0}", result);
            }
            else
            {
                Console.Write("Failed");
            }
            Console.WriteLine();

            fruits = new char[] { };
            result = test.MaxTwoFruitBasket(fruits);
            expected = 0;
            if (result == expected)
            {
                Console.Write("Passed: {0}", result);
            }
            else
            {
                Console.Write("Failed");
            }
            Console.WriteLine();
            fruits = new char[] { 'a' };
            result = test.MaxTwoFruitBasket(fruits);
            expected = 1;
            if (result == expected)
            {
                Console.Write("Passed: {0}", result);
            }
            else
            {
                Console.Write("Failed");
            }
            Console.WriteLine();

            fruits = new char[] { 'a', 'b', 'c' };
            result = test.MaxTwoFruitBasket(fruits);
            expected = 2;
            if (result == expected)
            {
                Console.Write("Passed:  {0}", result);
            }
            else
            {
                Console.Write("Failed");
            }

            
        }
    }

    }

