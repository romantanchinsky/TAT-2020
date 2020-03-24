using CarPark.Exceptions;
using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Engine
    {
        internal double Power { get; set; }
        internal double Capacity { get; set; }

        private string _type;
        internal string Type
        {
            get => _type;
            set
            {
                Checker checker = new Checker();
                if ( !checker.IsLatinLettersAndNumbers(value) )
                {
                    throw new ArgumentOutOfLatinLettersAndNumbersRangeException();                   
                }
                _type = value;
            }
        }

        internal string SerialNumber { get; set; }

        internal Engine ( double thePower, double theCapacity, string theType, string theSerialNumber )
        {
            Power = thePower;
            Capacity = theCapacity;
            Type = theType;
            SerialNumber = theSerialNumber;
        }

        internal Engine ( Engine theEngine )
        {
            Power = theEngine.Power;
            Capacity = theEngine.Capacity;
            Type = theEngine.Type;
            SerialNumber = theEngine.Type;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(Power.ToString());
            outString.AppendWithDelimiter(Capacity.ToString());
            outString.AppendWithDelimiter(Type);
            outString.AppendWithDelimiter(SerialNumber);
            return outString.ToString();
        }
    }
}
