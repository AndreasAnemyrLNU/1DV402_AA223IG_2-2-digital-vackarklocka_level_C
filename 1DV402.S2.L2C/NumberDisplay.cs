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
        private int _maxNumber;
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


        public NumberDisplay(int maxNumber)
            :this(maxNumber, 0)
        {
        }
        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
        }



        //?????????????????????????????
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Increment()
        {
            if (!(Number == MaxNumber))
            {
                Number++;
            }
            else
            {
                Number = 0;
            }
        }

        public override string ToString()
        {
            //Lägg till 0:a i sträng om Number är mindre än 10
            if (Number < 10)
            {
                return string.Format("0{0}", Number.ToString());
            }
            else
            {
                return Number.ToString();
            }

        }

    }
}
