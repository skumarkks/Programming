using System;
using System.Collections.Generic;

namespace PermutationNumbers
{
    public class Permutation
    {
        public void PermutationMethod1(string str, List<List<string>> results, int[] levels, char[] result, int level)
        {
            if (level == str.Length)
            {
                List<string> tempResult = new List<string>();
                tempResult.Add(new string(result));
                results.Add(tempResult);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (levels[i] == 0)
                    {
                        result[level] = str[i];
                        levels[i] = 1;
                        PermutationMethod1(str, results, levels, result,level+1);
                        levels[i] = 0;
                    }
                }
            }
        }

        //Time O(n!) and O(n!*n)
        void PermutationNumber(int[] nums, int l, int h, List<List<int>> perms)
        {
            if (l == h)
            {
                List<int> lnums = new List<int>(nums);
                perms.Add(lnums);
            }
            else
            {
                for (int i = l; i <= h; i++)
                {
                    swap(nums, l, i);
                    PermutationNumber(nums, l + 1, h, perms);
                    swap(nums, l, i);
                }
            }
        }

        public void PermutationString(char[] str, List<List<string>> result, int l, int h, char previous)
        {
            if (l == h)
            {
                var currentPerm = new List<string>();
                currentPerm.Add(new string(str));
                result.Add((currentPerm));
                return;
            }
            else
            {
                for (int i = l; i <=h; i++)
                {
                    char ch = str[i];
                    if(previous == ch) continue;
                    previous = ch;

                    swap(str,l,i);
                    PermutationString(str,result,l+1,h, previous);
                    swap(str, l, i);
                }
            }
        }

        void swap(char[] str, int i, int j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }


        void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] arg)
        {
            var test = new Permutation();

            string testStr = "AABC";
            List<List<string>> results = new List<List<string>>();
            int[] levels = new int[testStr.Length];
            char[] result = new char[testStr.Length];

            test.PermutationMethod1(testStr, results, levels, result, 0);




            //int[] nums = new int[] { 1, 1, 3,4 };
            //var perms = new List<List<int>>();
            //test.PermutationNumber(nums, 0, nums.Length - 1, perms);
        

            //foreach (var item in perms)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.Write("{0}", i);
            //    }
            //    Console.WriteLine();
            //}

            //string str = "AABC";
            //List<List<string>> result = new List<List<string>>();
            //result.Add(new List<string>());
            //char[] chletters = str.ToCharArray();

            ////Array.Sort(chletters);
            
            //var letters = new List<char>(chletters);
            //char previousChar = ' ';

            //test.PermutationString(chletters,result,0, chletters.Length-1,previousChar);

            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.Write("{0}", i);
            //    }
            //    Console.WriteLine();
            //}





        }
    }

}
