using System;
using System.Collections;
using System.Collections.Generic;

namespace MergeInterval
{
    class Interval
    {
        public int start;
        public int end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    };

    class IntervalComparer : IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            if(x.start < y.start)
            {
                return x.start;
            }
            else
            {
                return y.start;
            }
        }
    }
    

    class MergeInterval
    {
        public static List<Interval> GetMergeInterval(List<Interval> interval)
        {
            if (interval.Count < 2) return interval;

            interval.Sort(new IntervalComparer());

            List<Interval> mergedIntervals = new List<Interval>();
            
            var iterator = interval.GetEnumerator();
            iterator.MoveNext();

            int start = iterator.Current.start;
            int end = iterator.Current.end;

            while(iterator.MoveNext())
            {
                var currentStart = iterator.Current.start;
                var currentEnd = iterator.Current.end;

                if(currentStart <= end)
                {
                    end = Math.Max(end, currentEnd);

                }
                else
                {
                    mergedIntervals.Add(new Interval(start, end));
                    start = currentStart;
                    end = currentEnd;

                }

            }
            mergedIntervals.Add(new Interval(start, end ));

            return mergedIntervals;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Interval> input = new List<Interval>();
            input.Add(new Interval(1, 4));
            input.Add(new Interval(7, 9));
            input.Add(new Interval(2, 5));

            MergeInterval.GetMergeInterval(input);

            Console.WriteLine("Hello World!");
        }
    }
}
