using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class AlarmClock
    {
        //Aggregate to Clockdisplay (array)
        private ClockDisplay[] _alarmTimes;
        //Aggregate to Clockdisplay - current time
        private ClockDisplay _time;
        //Public property AlarmTimes Encapsulating _alarmTimes - type Clockdisplay 
        public string[] AlarmTimes 
        {
            //returns complete list of alarmtimes
            get
            {
                string[] alarmTimesArray = new string[_alarmTimes.Length];

                for (int i = 0; i < _alarmTimes.Length; i++)
                {
                    alarmTimesArray[i] = _alarmTimes[i].ToString();
                }
                return alarmTimesArray;
            }
            //Converts string to an object of type Clockdisplay
            set
            {
                    //Copy incoming value[] to alarmtimes for enhanced readability
                    string[] alarmTimes = value;
                    //Loops through array and creates objects of type Clockdisplay 
                    for(int i = 0; i < alarmTimes.Length;i++)
                    {
                        _alarmTimes[i] = new ClockDisplay();
                        _alarmTimes[i].Time = alarmTimes[i];
                    }
            }
        }
        //Property Time encapsulates _time. _time holds current time
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
        //Four Constructors + One another type of Constructor - accepting strings as argument/s
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
                //Collecting ErrorMessage if value not accepted by regx
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
                //Collecting ErrorMessage if value not accepted by regx
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
                //Collecting ErrorMessage if value not accepted by regx
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _time = null;
            }
          
                //Create one or more objects of type Clockdisplay. 
                //Nr of ojects to create are made up on alarmTimes.Length
            try
            {
                _alarmTimes = new ClockDisplay[alarmTimes.Length];
                    AlarmTimes = alarmTimes;
            }
            catch (FormatException e)
            {
                //Collecting ErrorMessage if value not accepted by regx
                Program.ErrorMessage += string.Format("{0}\n", e.Message);
                _alarmTimes = null;
            }

            
        }

        //Checks value equality of two different objs
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException();
            }
            return this.ToString() == obj.ToString();
        }
        //Returns hashcode by method ToString()
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        //Overrides operator != for objs of type AlarmClock
        public static bool operator != (AlarmClock a, AlarmClock b)
        {
            return a.Equals(b);
        }
        //Overrides operator == for objs of type AlarmClock
        public static bool operator == (AlarmClock a, AlarmClock b)
        {
            return a.Equals(b);
        }
        //Tick one min forward
        public bool TickTock()
        {
            _time.Increment();

            int length = AlarmTimes.Length;

            //Loops throug all alarmtimes...
            for (int ij = 0; ij < length; ij++)
            {
                //Test if new minutes has an alarmobject
                if(this.Time.Equals(AlarmTimes[ij]))
                {
                    return true;
                }
            }
            return false;
        }
        //Gives an string to output for every new minute.
        //To Do!    eplace concatenating with other methods!!!!!
        public override string ToString()
        {
            string str = "";
            if (!(_alarmTimes == null))
            {
                for (int i = 0; i < _alarmTimes.Length; i++ )
                {
                    str += _alarmTimes[i].ToString();
                    if (i != _alarmTimes.Length -1)
                    {
                        str += " ";
                    }
                }
                return string.Format("{0,7} ({1})", _time.ToString(), str);
            }
            return "";
        }
    }
}
