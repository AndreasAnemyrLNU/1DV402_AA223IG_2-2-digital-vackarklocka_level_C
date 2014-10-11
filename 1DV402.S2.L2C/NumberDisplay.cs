using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2C
{
    class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        public int MaxNumber
        {
            get { return _maxNumber; }
            set 
            { 
                //Validerar ett inkommannde value större än 0
                if(!(0 < value))
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

        public NumberDisplay(int maxNumber)
            :this(maxNumber, 0) { }
        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
        }

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
            return Number.ToString();
        }

        public string ToString(string format)
        {
            //Lägg till inledande 0:a i sträng om Number är mindre än 10 och om formatsträngen är lika med "00
            if ("00" == format)
            {
                if (Number < 10)
                {
                    return string.Format("0{0}", Number.ToString());
                }
                else
                {
                    return Number.ToString();
                }

            }
            //Åsidossätt inledande nolla om formatsträng är "0" eller "G"
            else if (("0" == format) || ("G" == format))
            {
                return Number.ToString();
            }
            else throw new FormatException();

        }



    }
}
