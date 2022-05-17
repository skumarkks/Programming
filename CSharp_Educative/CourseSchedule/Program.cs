using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSchedule
{
    class Program
    {
        public bool dfs(int crs, List<int> cycle, List<int> visited, List<List<int>> courseMap, List<int> output)
        {
            if (cycle.Contains(crs))
                return false;
            if (visited.Contains(crs))
                return true;
            cycle.Add(crs);
            foreach (var pre in courseMap[crs])
            {
                if (dfs(pre, cycle, visited, courseMap, output) == false)
                {
                    return false;
                }

                cycle.Remove(crs);
                visited.Add(crs);
                output.Add(crs);
                return true;
            }
            return true;
        }

        public List<int> FindCourse(int numCourses, List<List<int>> prerequisite)
        {
            var courseMap = new List<List<int>>();
            var courseList = new List<int>();

            foreach (var item in prerequisite)
            {
                if (courseMap[item[0]] == null)
                    courseMap[item[0]] = new List<int>();

                courseMap[item[0]].Add(item[1]);
                if(!courseList.Contains(item[0]))
                {
                    courseList.Add(item[0]);
                }
                if(!courseList.Contains(item[1]))
                {
                    courseList.Add(item[1]);
                }
            }

            var output = new List<int>();
            var visited = new List<int>();
            var cycle = new List<int>();

            foreach (var c in courseList)
            {
                if (dfs(c, cycle, visited, courseMap, output) == false)
                {
                    return null;
                }
            }

            return output;
        }
        
        static void Main(string[] args)
        {
            var p = new Program();
            var prereq = new List<List<int>>();
            var temp = new List<int> {1, 0};
            prereq.Add(temp);
            var output = p.FindCourse(2, prereq);
        }
    }
}
