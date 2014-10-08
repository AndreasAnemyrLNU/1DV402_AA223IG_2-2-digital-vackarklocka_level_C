using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class NumberDisplay
    {
        //Fält start--------------------------------------
        private int _maxNumber = 200;
        private int _number;
        //Fält slut---------------------------------------

        //Egenskaper start++++++++++++++++++++++++++++++++

        //Inkaplsar _maxNumber
        public int MaxNumber
        {
            get { return _maxNumber; }
            set 
            { 
                //Valierar ett inkommannde value större än 0
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maxNumber = value; 
            }
        }
        //
        public int Number
        {
            get { return _number; }
            set 
            {
            //Validera value till ett slutet intervalla melan 0 och MaxNumber
                if(value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException();
                }
            _number = value; 
            }
        }
        //Egenskaper slut+++++++++++++++++++++++++++++++++

        //Konstruktorer start-----------------------------
        public NumberDisplay(int maxnumber)
            :this(maxnumber, number)
        { }

        public NumberDisplay(int maxnumber, int number) { }


        //Konstruktorer slut------------------------------


    }
}
