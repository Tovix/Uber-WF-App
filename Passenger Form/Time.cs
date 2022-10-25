using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger_Form
{
    public class Time : EventArgs
    {
        public bool now { get; }
        public string date {get;}
        public string hours { get; }
        public string minutes {get;}
        public string am_or_pm {get;}
        public Time(Time time, bool now)
        {
            if(time != null)
            {
                this.date = time.date;
                this.hours = time.hours;
                this.minutes = time.minutes;
                this.am_or_pm = time.am_or_pm;
            }
            this.now = now;
        }

        public Time(string date, string hours, string minutes, string am_or_pm, bool now)
        {
            this.date = date;
            this.hours = hours;
            this.minutes = minutes;
            this.am_or_pm = am_or_pm;
            this.now = now;
        }

        public static Time CurrentTime()
        {
            string currDate = DateTime.Now.ToString("dddd, dd MMMM");
            string currHours = DateTime.Now.ToString("hh");
            string currMinutes = DateTime.Now.ToString("mm");
            string currAm_or_PM = DateTime.Now.ToString("tt");
            return new Time(currDate, currHours, currMinutes, currAm_or_PM, true);
        }

        public static bool validTime(Time time)
        {
            Time currTime = Time.CurrentTime();
            if (time.date == currTime.date)
            {
                if (time.am_or_pm == currTime.am_or_pm)
                {
                    if ((int.Parse(time.hours) == 12 && int.Parse(currTime.hours) < 12))
                    {
                        return false;
                    }
                    else if (int.Parse(time.hours) < int.Parse(currTime.hours) ||
                            (int.Parse(time.hours) == int.Parse(currTime.hours) &&
                            int.Parse(time.minutes) < int.Parse(currTime.minutes)))
                    {
                        return false;
                    }
                }
                else if (time.am_or_pm == "AM" && currTime.am_or_pm == "PM")
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isCurrentTime(Time time)
        {
            Time currTime = Time.CurrentTime();
            return (time.date == currTime.date && time.hours == currTime.hours.TrimStart('0') &&
                        time.minutes == currTime.minutes.TrimStart('0') && time.am_or_pm == currTime.am_or_pm);
        }
    }
}
