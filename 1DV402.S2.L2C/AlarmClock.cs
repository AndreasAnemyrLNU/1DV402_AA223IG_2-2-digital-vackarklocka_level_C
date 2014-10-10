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
        private ClockDisplay[] _alarmTimes;
        //Aggregat Tiden
        private ClockDisplay _time;

        public string[] AlarmTimes 
        {
            get
            {
                string[] alarmTimesToStringArr = new string[_alarmTimes.Length];

                for (int i = 0; i < _alarmTimes.Length; i++)
                {
                    alarmTimesToStringArr[i] = _alarmTimes[i].ToString();
                }
                return alarmTimesToStringArr;
            }
            //set{}; 
        }
       
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
          
            
           _alarmTimes = new ClockDisplay[1]{new ClockDisplay()};
                _alarmTimes[0].Time = string.Format("{0}:{1}", alarmHour, alarmMinute);
        }
        public AlarmClock(string time, params string[] alarmTimes)
        {

        }

        public override string ToString()
        {
            return string.Format("{0} ({1})",_time.ToString(), _alarmTimes[0].ToString());
        }

    }
}
