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
                //Validate incoming value to true if it's greater than 0
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
            //VAlidate incoming value to a closed interval between 0 and MaxNumber
                if(value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException();
                }
            _number = value; 
            }
        }
        //Constructors
        public NumberDisplay(int maxNumber)
            :this(maxNumber, 0) { }
        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
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
            if (!(Number == MaxNumber))
            {
                Number++;
            }
            else
            {
                //Sets to 0 if Number has come to MaxNumber
                Number = 0;
            }
        }

        public static bool operator !=(NumberDisplay a, NumberDisplay b)
        {
            return !(a == b);
        }

        public static bool operator ==(NumberDisplay a, NumberDisplay b)
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
            return Number.ToString();
        }

        public string ToString(string format)
        {
            //Add Zero in beginning if Number has a value less than 10 and if format is equal to "00"
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
            //If format is set to "0" or "G"
            else if (("0" == format) || ("G" == format))
            {
                return Number.ToString();
            }
            else throw new FormatException();

        }



    }
}
