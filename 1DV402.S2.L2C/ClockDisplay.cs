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
        //Ref till ett NumberDisplayobj ansvarar för timmarna.
        //Kapslas delvis in av egenskapen Time, som är av typen string
        private NumberDisplay _hourDisplay;

        //Ref till ett NumberDisplayobj ansvarar för minuterna.
        //Kapslas delvis in av egenskapen Time, som är av typen string
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
                //Kontroll av indata genom reguljärt uttryck
                //Indata kommer SKA komma i form av HH:mm
                Regex rgx = new Regex("^(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])$");

                if ( rgx.IsMatch(value))
                {
                    string[] values = value.Split(':');
                    _hourDisplay.Number = int.Parse(values[0]);
                    _minuteDisplay.Number = int.Parse(values[1]);
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

            public ClockDisplay()
                :this(0,00)
            {
            //Tom
            }
            public ClockDisplay(int hour, int minute)
            {
                _hourDisplay = new NumberDisplay(23);
                _minuteDisplay = new NumberDisplay(59);
            }

            public ClockDisplay(string time)
            {
                //Tom
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
       

            //Börjar nu på nästa då jag försöker få en förståelse för aggregat och sammangahnget i sig...
            public void Increment()
            {
                //Nollställ minuter om 59
                if(_minuteDisplay.Number != 59)
                {
                    _minuteDisplay.Number++;
                }
                else
                {
                    _minuteDisplay.Number = 0;

                    //Nollställ timmarna om 23
                    if(_hourDisplay.Number != 23){
                        _hourDisplay.Number++;
                    }
                    else
                    {
                        _hourDisplay.Number = 0;
                    }
                }
            }

            public override string ToString()
            {
                return string.Format("{0}:{1}",_hourDisplay.ToString("0"),_minuteDisplay.ToString("00"));
            }
    }
}
