using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Demo_3.Classes
{
    public class TimeOperations
    {
        int _duration;  // in seconds
        string _time;   // dk
        public TimeOperations(int duration)
        {
            _duration = duration;
        }
        public TimeOperations(string time)
        {
            _time = time;
        }

        public string CalcutureTime()
        {
            int hour, minute, second, hourSecond, minuteSecond;
            hour = _duration / 60 / 60; //3600' de olur
            hourSecond = hour * 60 * 60;
            minute = (_duration - hourSecond) / 60;
            if (minute >= 60)
                minute = (_duration - hourSecond) % 60;
            minuteSecond = minute * 60;
            second = _duration - hourSecond - minuteSecond;
            return hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
            //return hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
        }
        public int CalculateDuration()
        {
            int hours = Convert.ToInt32(_time.Split(':')[0]);
            int minutes = Convert.ToInt32(_time.Split(':')[1]);
            int seconds = Convert.ToInt32(_time.Split(':')[2]);
            return hours * (int)Math.Pow(60, 2) + minutes * 60 + seconds;


        }
    }
}
