using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarMatching
{
    class Program
    {
        public static List<stringMeeting> MeetingAvailability(
            List<stringMeeting> calender1,
            List<stringMeeting> calender2,
            stringMeeting dailyBound1,
            stringMeeting dailyBound2,
            int meetingMinutes)
        {
            List<Meeting> updateMeeting1 = UpdateMeeting(calender1, dailyBound1);
            List<Meeting> updateMeeting2 = UpdateMeeting(calender2, dailyBound2);
            List<Meeting> mergeMeeting = MergeMeeting(updateMeeting1, updateMeeting2);
            List<Meeting> flattenCalender = FlattenCalender(mergeMeeting);

            return AvailableSchedules(flattenCalender, meetingMinutes);

        }

        private static List<stringMeeting> AvailableSchedules(List<Meeting> flattenCalender, int meetingMinutes)
        {
            int i = 1;

            Meeting previousMeeting = flattenCalender[0];

            List<stringMeeting> availableCalendar = new List<stringMeeting>();

            while (i < flattenCalender.Count)
            {
                int previousEnd = previousMeeting.end;
                int currentStart = flattenCalender[i].start;

                if (currentStart - previousEnd >= meetingMinutes)
                {
                    availableCalendar.Add(new stringMeeting(
                                TimeToHourMinutesString(previousEnd+1),
                                TimeToHourMinutesString(currentStart-1)
                                ));
                }
                
                previousMeeting = flattenCalender[i];
                i++;
            }

            return availableCalendar;
        }

        public static string TimeToHourMinutesString(int time)
        {
            int hour = time / 60;
            int min = time % 60;
            
            string hoursString = hour < 10 ? "0" + min.ToString() : hour.ToString();
            string minString = min < 10 ? "0" + min.ToString() : min.ToString();
            
            return hoursString + ":" + minString;
        }

        private static List<Meeting> FlattenCalender(List<Meeting> mergeMeeting)
        {
            List<Meeting> flattenMeeting = new List<Meeting>();
            int start = 0;
            int end = 0;

            for (int i = 0; i < mergeMeeting.Count; i++)
            {
                start = mergeMeeting[i].start;
                for (int j = i; j < mergeMeeting.Count; j++)
                {
                    if (j+1 < mergeMeeting.Count && mergeMeeting[j].end >= mergeMeeting[j + 1].start)
                    {
                        end = mergeMeeting[j + 1].end;
                    }
                    else
                    {
                        break;
                        i = j;
                    }

                }

            }

            return flattenMeeting;
        }

        private static List<Meeting> MergeMeeting(List<Meeting> updateMeeting1, List<Meeting> updateMeeting2)
        {
            int i = 0;
            int j = 0;

            List<Meeting> mergeMeeting = new List<Meeting>();

            while (i < updateMeeting1.Count && j < updateMeeting2.Count)
            {
                if (updateMeeting1[i].start <= updateMeeting2[j].start)
                {
                    mergeMeeting.Add(updateMeeting1[i]);
                    i++;
                }
                else
                {
                    mergeMeeting.Add(updateMeeting1[j]);
                    j++;
                }
            }

            if (i < updateMeeting1.Count && j == updateMeeting2.Count)
            {
                for (int k = i; k < updateMeeting1.Count; k++)
                {
                    if (k+1 <= updateMeeting1.Count && updateMeeting1[k].start < updateMeeting1[k + 1].start)
                        mergeMeeting.Add(updateMeeting1[k]);
                }
            }

            if (i == updateMeeting1.Count && j < updateMeeting2.Count)
            {
                for (int k = j; k < updateMeeting2.Count; k++)
                {
                    if (k + 1 <= updateMeeting2.Count && updateMeeting2[k].start < updateMeeting2[k + 1].start)
                        mergeMeeting.Add(updateMeeting2[k]);
                }
            }

            return mergeMeeting;
        }

        private static List<Meeting> UpdateMeeting(List<stringMeeting> calender1, stringMeeting dailyBound1)
        {
            List<stringMeeting> updatedMeeting = new List<stringMeeting>();
            updatedMeeting.Add(new stringMeeting("0:00", dailyBound1.start));
            updatedMeeting.Add(new stringMeeting(dailyBound1.end,"23:59"));
            updatedMeeting.AddRange(calender1);

            List<Meeting> updatedMeetingInMinutes = new List<Meeting>();
            
            for (int i = 0; i < updatedMeeting.Count; i++)
            {
                updatedMeetingInMinutes.Add(new Meeting(
                    timeInMinutes(updatedMeeting[i].start),
                    timeInMinutes(updatedMeeting[i].end)));
            }

            return updatedMeetingInMinutes;
        }

        private static int timeInMinutes(string start)
        {
            char delimitor = ':';
            int delimitorIdx = start.IndexOf(delimitor);

            int hoursMinutes = int.Parse(start.Substring(0,delimitorIdx)) * 60;
            int minutes = int.Parse(start.Substring(delimitorIdx + 1));

            return hoursMinutes + minutes;
        }


        static void Main(string[] args)
        {
        }
    }

    public class stringMeeting
    {
        public string start;
        public string end;

        public stringMeeting(string start, string end)
        {
            this.start = start;
            this.end = end;
        }
    }

    public class Meeting
    {
        public int start;
        public int end;

        public Meeting(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
