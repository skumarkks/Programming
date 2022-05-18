using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Elements_NormalizePathNames
{
    class Program
    {
        public static string SimplifyPath(string pathString)
        {
            int totalLength = 0;
            LinkedList<KeyValuePair<int, int>> res = new LinkedList<KeyValuePair<int, int>>();
            int lastSlash = -1;

            //converting the path into a char array
            char[] path = pathString.ToCharArray();

            for (int i = 0; i <= path.Length; i++)
            {
                //if i is equal to the length of th string or character is /
                if (i == path.Length || path[i] == '/')
                {
                    //if the last character is not a slash
                    if (i - lastSlash > 1)
                    {
                        if (path[i - 1] == '.' && (i - 2 == lastSlash || (i - 3 == lastSlash && path[i - 2] == '.')))
                        {
                            if (i - 3 == lastSlash && res.Count > 0)
                            {
                                totalLength -= res.Last.Value.Value;
                                res.RemoveLast();
                            }
                        }
                        else
                        {
                            int begin = lastSlash > -1 ? lastSlash : 0;
                            int length = i - begin;
                            totalLength += length;
                            res.AddLast(new KeyValuePair<int, int>(begin, length));
                        }
                    }

                    lastSlash = i;
                }
            }

            if (res.Count == 0) return "/";

            char[] final = new char[totalLength];
            int index = 0;
            foreach (KeyValuePair<int, int> segment in res)
            {
                Array.Copy(path, segment.Key, final, index, segment.Value);
                index += segment.Value;
            }

            return new string(final);
        }

        public static string NormalizePathNames(string strPath)
        {
            //if the string is null and not containing . or .. pattern
            //return the same string with appended /

            if (string.IsNullOrEmpty(strPath))
            {
                return null;
            }

            string[] strSplit = strPath.Split('/');
            Stack<String> stack = new Stack<string>();

            //if the path contains /  then split the string based on /
            // if the string is no . or .. push them to stack
            // on encountering .. pop the stack 
            // always insert /
            // ignore .

            int count = 0;
            while (strSplit.Length > count)
            {
                if (string.Equals(strSplit[count], ".") || string.Equals(strSplit[count], ".."))
                {
                    if (string.Equals(strSplit[count], ".."))
                    {
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    if (!string.Equals(strSplit[count], ""))
                    {
                        stack.Push(strSplit[count]);
                    }
                }
                count++;
            }

            if (stack.Count == 0)
            {
                return "/";
            }

            string result = null;
            while (stack.Count != 0)
            {
                result = "/" + stack.Pop() + result;
            }
            

            return result;
        }

        static void Main(string[] args)
        {
            string str = SimplifyPath("/home/");
            Console.WriteLine("/home/");
            Console.WriteLine(str);

            str = NormalizePathNames("/a/./b/../../c/");
            Console.WriteLine("/a/./b/../../c/");
            Console.WriteLine(str);

            str = SimplifyPath("/a/../../b/../c//.//");
            Console.WriteLine("/a/../../b/../c//.//");
            Console.WriteLine(str);

            str = NormalizePathNames("/a//b////c/d//././/..");
            Console.WriteLine("/a//b////c/d//././/..");
            Console.WriteLine(str);

            str = NormalizePathNames("/../");
            Console.WriteLine("/../");
            Console.WriteLine(str);

            str = NormalizePathNames("/home//foo/");
            Console.WriteLine("/home//foo/");
            Console.WriteLine(str);
        }
    }
}
