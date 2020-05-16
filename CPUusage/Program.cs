using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CPUusage
{
    public class Job
    {
        public int start;
        public int end;
        public int cpu;
        public Job()
        {

        }
        public Job(int start, int end, int cpu)
        {
            this.start = start;
            this.end = end;
            this.cpu = cpu;
        }
    }

    public class CPUUSage
    {
        public  int FindMaxCpuUsage(List<Job> jobs)
        {
            if (jobs.Count== 0) return 0;
            jobs = jobs.OrderBy(j => j.start).ToList();

            var minHeap = new ConcurrentPriorityQueue<Job>();

            foreach (var job in jobs)
            {
                while(minHeap.Count != 0 && job.start > minHeap.Peek().end)
                {
                    
                }
            }
        }

        
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
