using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class AlarmClock
    {
        //Ansvarar för alarmtiderna
        private ClockDisplay _alarmTimes;
        //Ansvarar för väckarklockans aktuella tid
        private ClockDisplay _time;

        public string[] Alarmtimes
        {
            get
            {
                //Ge en array innehållande alarmtider i form av strängar
                //Egenskapen konverterar alltså referenser till ClockDisplay-objekt till strängar
                //Vid ändring av en sträng i arrayen ska inte underligande ClockDisplay-objekt ändras
                return;
            }
            set
            //Konverterar varje alarmtid, i form av en sträng,
            //till ett ClockDisplay-objekt
            {

            }


        }

        public string Time
        {
            get
            {

            }
            set
            {

            }
        }

        public AlarmClock() 
            :this(0,0)
        { 
            //Ingen tilldelning här. Skicka vidare.
        }
        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        {
            //Ingen tilldelning här. Skicka vidare.
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _alarmTimes = new ClockDisplay();
            _time = new ClockDisplay();
        }
    }
}
