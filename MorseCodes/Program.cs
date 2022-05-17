using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var codes = new string[]
            {
                ".-",
                "-...",
                "-.-.",
                "-..",
                ".",
                "..-.",
                "--.",
                "....",
                "..",
                ".---",
                "-.-",
                ".-..",
                "--",
                "-.",
                "---",
                ".--.",
                "--.-",
                ".-.",
                "...",
                "-",
                "..-",
                "...-",
                ".--",
                "-..-",
                "-.--",
                "--.."
            };

            String str = "SOS";
            string ret;

            foreach (var ch in str)
            {

                ret += codes[ch-'A'];
            }

            Console.WriteLine(ret);
        }   
        
    }
}
