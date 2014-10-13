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
                string[] alarmTimesArray = new string[_alarmTimes.Length];

                for (int i = 0; i < _alarmTimes.Length; i++)
                {
                    alarmTimesArray[i] = _alarmTimes[i].ToString();
                }
                return alarmTimesArray;
            }
            set
            {
                    //Kopierar inkommande array values värde till array alarmTimes för förbättrad läsbarhet
                    string[] alarmTimes = value;
                    //Loopar genom arry och skapar ClockDisplay objekt för varje sträng
                    for(int i = 0; i < alarmTimes.Length;i++)
                    {
                        _alarmTimes[i] = new ClockDisplay();
                        _alarmTimes[i].Time = alarmTimes[i];
                    }
            }
        }
       
        public string Time 
        {
            get
            {
                return _time.Time;
            }
            set
            {
                _time.Time = value;
            }
        }

        public AlarmClock() 
            :this(0, 0)  {}
         
        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)   {}

        public 
            AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            try
            {
                _time = new ClockDisplay();
                    _time.Time = string.Format("{0}:{1,1:D2}", hour, minute);
            }
            catch (FormatException e)
            {
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _time = null;
            }
          
            try
            {
                _alarmTimes = new ClockDisplay[1]{new ClockDisplay()};
                    _alarmTimes[0].Time = string.Format("{0}:{1,1:D2}", alarmHour, alarmMinute);
            }
            catch (FormatException e)
            {
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _alarmTimes = null;
            }
        }
        public AlarmClock(string time, params string[] alarmTimes)
        {
            
            try
            {
                _time = new ClockDisplay();
                    _time.Time = time;
            }
            catch (FormatException e)
            {
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _time = null;
            }
          
                //Skapar rätt antal ClockDisplayobjekt
            try
            {
                _alarmTimes = new ClockDisplay[alarmTimes.Length];
                    AlarmTimes = alarmTimes;
            }
            catch (FormatException e)
            {
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _alarmTimes = null;
            }

            
        }

        //Nu ger jag mig på en att förstå Equals :)
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!(obj is string))
            {
                return false;
            }

            if (obj.ToString() == _time.ToString())
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
            {
 	            return base.GetHashCode();
            }

        public bool TickTock()
        {
            _time.Increment();

            int length = AlarmTimes.Length;

            //ij säger vart i stränger jag är
            for (int ij = 0; ij < length; ij++)
            {
                //om nuvarande alarmtid är vad tiden är så!
                if(Equals(AlarmTimes[ij]))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            if (!(_alarmTimes == null))
            {
                foreach (ClockDisplay _alarmTime in _alarmTimes)
                {
                    str += _alarmTime.ToString();
                }
                return string.Format("{0} ({1})", _time.ToString(), str);
            }
            return "";

        }

    }
}
