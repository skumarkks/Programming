using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermuteCharacterWithoutOrderChanging
{
    class Program
    {
        public static List<string> FindPermutations(string input)
        {
            if (input.Length == 0) return null;
            char[] cInput = input.ToCharArray();
            List<string> perms = new List<string>();
            perms.Add(new string(cInput));

            for (int i = 0; i < cInput.Length; i++)
            {
                int n = perms.Count;

                if (!char.IsDigit(cInput[i]))
                {
                    for (int j = 0; j < n; j++)
                    {
                        char[] perm = perms[j].ToCharArray();
                        if(char.IsUpper(perm[i]))
                        {
                            perm[i] = char.ToLower(perm[i]);
                        }
                        else
                        {
                            perm[i] = char.ToUpper(perm[i]);
                        }
                        perms.Add(new string(perm));

                    }
                }
            }
            return perms;
        }

        
        static void Main(string[] args)
        {

            string test = "ab7c";
            var result = Program.FindPermutations(test);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
