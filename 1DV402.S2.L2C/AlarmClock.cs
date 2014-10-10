using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class AlarmClock
    {

        //Aggregat alarmtiderna
        private ClockDisplay _alarmTimes;
        //Aggregat Tiden
        private ClockDisplay _time;

        public string[] AlarmTimes { get; set; }
       
        public string Time { get; set; }

        public AlarmClock() 
            :this(0,0)  {}

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)   {}

        public 
            AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _time = new ClockDisplay();
                _time.Time = string.Format("{0}:{1}", hour, minute);
            
            _alarmTimes = new ClockDisplay();
                _alarmTimes.Time = string.Format("{0}:{1}", alarmHour, alarmMinute);
        }
        public AlarmClock(string time, params string[] alarmTimes)
        {

        }
    }
}
