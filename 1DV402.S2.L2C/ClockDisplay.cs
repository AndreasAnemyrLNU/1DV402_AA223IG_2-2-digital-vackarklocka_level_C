using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //Hur fungerar reguljärt uttryck. Kolla!
                if (value == "^(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])$")
                {
                    _hourDisplay = new NumberDisplay(23);
                    _minuteDisplay = new NumberDisplay(59);

                    string[] values = value.Split(':');
                    _hourDisplay.Number =  int.Parse(values[0]);
                    _minuteDisplay.Number = int.Parse(values[1]);

                }
                else
                {
                    throw new FormatException();
                }
            }
        }

            public ClockDisplay()
                :this(0,0)
            {
            //Tom
            }
            public ClockDisplay(int hour, int minute)
            {
                //Vilket fält är det som ska tilldelas och hur?
                _hourDisplay = hour;
                _minuteDisplay = minute;
            }

            public ClockDisplay(string time)
            {
                Time = time;
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

        




    }
}
