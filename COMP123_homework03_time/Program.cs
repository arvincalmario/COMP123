using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_homework03_time
{
    class Program
    {
        enum TimeFormat
        {
            Mil,
            Hour12,
            Hour24
        }
        static void Main(string[] args)
        {
            //create a list to store the objects
            List<Time> times = new List<Time>()
            {
                new Time(9, 35),
                //new Time(18, 5),
                //new Time(20, 500),
                //new Time(10),
                //new Time()
            };

            //display all the objects
            TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"\n\nTime format is {format}");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            format = TimeFormat.Mil;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetFormat(format);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            format = TimeFormat.Hour24;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

        }
        class Time
        {
            private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;

            public int Hour { get; }
            public int Minute { get; }

            public Time(int hour = 0, int minute = 0)
            {
                Hour = hour;
                Minute = minute;

                Hour = (hour > 0 && hour < 24) ? hour : 0;
                Minute = (minute > 0 && minute < 60) ? minute : 0;
            }

            public override string ToString()
            {
                switch (TIME_FORMAT)
                {
                    case TimeFormat.Mil:
                        return $"{Hour:d2}{Minute:d2}";
                        break;                        
                    case TimeFormat.Hour24:
                        return $"{Hour:d2}:{Minute:d2}";
                        break;
                    case TimeFormat.Hour12:
                        int hour12;
                        hour12 = (Hour < 12) ? Hour : (Hour - 12);

                        string AMPM;
                        AMPM = Hour < 12 ? "AM" : "PM";

                        return $"{hour12}:{Minute:d2} {AMPM}";
                        break;
                    default:
                        return $"invalid format, try again";
                        break;
                }
            }

            public static void SetFormat (TimeFormat timeFormat)
            {
                TIME_FORMAT = timeFormat;
            }
        }
    }
}
