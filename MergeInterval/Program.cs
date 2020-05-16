using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MergeInterval
{
    class Interval
    {
        public int start;
        public int end;
        public Interval()
        {

        }
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public List<Interval> InsertInterval(List<Interval> intVals, Interval bInt)
        {
            for (int i = 0; i < intVals.Count; i++)
            {
                var aInt = intVals[i];
                if (aInt.end < bInt.start)
                {
                    intVals.Insert(i + 1, bInt);
                    var result = MergeIntervals(intVals, i+1);
                    return result;
                }
            }
            return null;
        }


        public List<Interval> MergeIntervals(List<Interval> intList, int i)
        {
            if (intList.Count == 1) return intList;

            intList = intList.OrderBy(p => p.start).ToList();
            var temp = new Interval();

            for (; i <= intList.Count - 2; i++)
            {
                var int1 = intList[i];
                var int2 = intList[i + 1];

                if (int1.start < int2.start &&
                    int1.end < int2.start)
                    continue;
                else if ((int1.start == int2.start &&
                    int1.end < int2.end) ||
                    (int1.start < int2.start &&
                     int1.end < int2.end))
                {
                    temp.start = int1.start;
                    temp.end = int2.end;
                    int2.start = temp.start;
                    int2.end = temp.end;
                    intList.RemoveAt(i);
                    i = i - 1;
                }
                else if (int1.start < int2.start &&
                        int1.end >= int2.end)
                {
                    temp.start = int1.start;
                    temp.end = int1.end;
                    int2.start = temp.start;
                    int2.end = temp.end;
                    intList.RemoveAt(i);
                    i = i - 1;
                }
            }
            return intList;
        }
    }

    
    

    
    class Program
    {
        static void Main(string[] args)
        {
            var intObj = new Interval();

            /*
            //MergeTest
            List<Interval> input = new List<Interval>();
            input.Add(new Interval(1, 4));
            input.Add(new Interval(7, 9));
            input.Add(new Interval(2, 5));

            var result = intObj.MergeIntervals(input);

            foreach(var item in result)
            {
                Console.WriteLine("({0},{1})", item.start, item.end);
            }

            Console.WriteLine();

            input = new List<Interval>();
            input.Add(new Interval(6, 7));
            input.Add(new Interval(2, 4));
            input.Add(new Interval(5, 9));

            result = intObj.MergeIntervals(input);

            foreach (var item in result)
            {
                Console.WriteLine("({0},{1})", item.start, item.end);
            }

            Console.WriteLine();

            input = new List<Interval>();
            input.Add(new Interval(1, 4));
            input.Add(new Interval(2, 6));
            input.Add(new Interval(3, 5));

            result = intObj.MergeIntervals(input);

            foreach (var item in result)
            {
                Console.WriteLine("({0},{1})", item.start, item.end);
            }
            */

            List<Interval> input = new List<Interval>();
            input.Add(new Interval(1, 3));
            input.Add(new Interval(5, 7));
            input.Add(new Interval(8, 12));

            var result = intObj.InsertInterval(input, new Interval(4,6));

            foreach (var item in result)
            {
                Console.WriteLine("({0},{1})", item.start, item.end);
            }

            Console.WriteLine();


            Console.WriteLine("Hello World!");
        }
    }
}
