using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class Duration
    {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public Duration(int totalSeconds)
            {
                Hours = totalSeconds / 3600;
                totalSeconds %= 3600;
                Minutes = totalSeconds / 60;
                Seconds = totalSeconds % 60;
            }
            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }
            public override string ToString()
            {
                return $"Hours:{Hours}, Minutes:{Minutes}, Seconds:{Seconds}";
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }

            public override bool Equals(object? obj)
            {
                if (obj is Duration other)
                {
                    return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
                }
                return false;
            }
        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration a, Duration b)
        {
             return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
        }

        public static Duration operator +(Duration a, int sec)
        {
            return new Duration(a.Hours,a.Minutes,a.Seconds+sec);
        }
        public static Duration operator +(int sec,Duration a)
        {
            return a+sec;
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration(a.Hours,a.Minutes+1,a.Seconds);
        }
        public static Duration operator --(Duration a)
        {
            return new Duration(a.Hours, a.Minutes - 1, a.Seconds);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            int totalSeconds1 = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            int totalSeconds2 = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;
            int difference = totalSeconds1 - totalSeconds2;
            return new Duration(difference);
        }
        public static bool operator >(Duration a, Duration b)
        {
            return a.TotalSeconds() > b.TotalSeconds();
        }
        public static bool operator <(Duration a, Duration b)
        {
            return a.TotalSeconds() < b.TotalSeconds();
        }
        public static bool operator >=(Duration a, Duration b)
        {
            return a.TotalSeconds() >= b.TotalSeconds();
        }
        public static bool operator <=(Duration a, Duration b)
        {
            return a.TotalSeconds() <= b.TotalSeconds();
        }
        public static implicit operator bool(Duration a)
        {
            return a.Hours != 0 || a.Minutes != 0 || a.Seconds != 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

    }
}
