using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1DV402.S2.L2C
{
    class ClockDisplay
    {
        //Ref, aggr to an object of type Numberdisplay. Resp for hours (HH)
        //Encapsulated partially by property Time
        private NumberDisplay _hourDisplay;

        //Ref, aggr to an object of type Numberdisplay. Resp for minutes (mm)
        //Encapsulated partially by property Time
        private NumberDisplay _minuteDisplay;

        //
        public string Time
        {
            get 
            { 
                return string.Format("{0}:{1}", _hourDisplay, _minuteDisplay);  
            }
            set
            {
                //Incoming data controlled by regx
                //Valid data should be in format ---> HH:mm
                Regex rgx = new Regex("^(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])$");

                if (rgx.IsMatch(value))
                {
                    string[] values = value.Split(':');
                    _hourDisplay.Number = int.Parse(values[0]);
                    _minuteDisplay.Number = int.Parse(values[1]);
                }
                else
                {
                    throw new FormatException(string.Format(Properties.Resources.NotValidStringHHmm,value));
                }
            }
        }

            public ClockDisplay()
                :this(0,0)
            {
                //Empty
            }
            public ClockDisplay(int hour, int minute)
            {
                //23 because of hours...
                _hourDisplay = new NumberDisplay(23);
                //59 because of minutes
                _minuteDisplay = new NumberDisplay(59);
            }

            public ClockDisplay(string time)
            {
                //Empty
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    throw new ArgumentNullException();
                }
                return this.ToString() == obj.ToString();
            }

            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }
       
            public void Increment()
            {
                //Set Number to Zero if Number is 59
                if(_minuteDisplay.Number != 59)
                {
                    _minuteDisplay.Number++;
                }
                else
                {
                    _minuteDisplay.Number = 0;

                    //Set Number to Zero if Number is 23
                    if(_hourDisplay.Number != 23){
                        _hourDisplay.Number++;
                    }
                    else
                    {
                        _hourDisplay.Number = 0;
                    }
                }
            }

            public static bool operator !=(ClockDisplay a, ClockDisplay b)
            {
                return !(a == b);
            }

            public static bool operator ==(ClockDisplay a, ClockDisplay b)
            {
                //Check if a is null
                //(operator== would be recursive)
                if (ReferenceEquals(a, null))
                {
                    //Return true if b is also full
                    //but false otherwise
                    return ReferenceEquals(b, null);
                }
                return a.Equals(b);
            }

            public override string ToString()
            {
                return string.Format("{0}:{1}",_hourDisplay.ToString("0"),_minuteDisplay.ToString("00"));
            }
    }
}
