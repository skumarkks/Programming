using System;

namespace ReverseString
{
    class Program
    {
        public void Reverse(string str, int index)
        {
            if (index == str.Length - 1)
            { 
                Console.WriteLine(str[index]);
                return;
            }
            Reverse(str, index+1);
            Console.WriteLine(str[index]);
            return;
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            prg.Reverse("Hello World",0);
            //prg.Reverse("s", 0);

            //Console.WriteLine("Hello World!");
        }
    }
}
