using CarPark.Exceptions;
using System.Text;

namespace CarPark.Entities.Spares
{
    internal class Transmission
    {
        private string _type;
        internal string Type
        {
            get => _type;
            private set
            {
                Checker checker = new Checker();
                if ( !checker.IsLatinLettersAndNumbers(value) )
                {
                    throw new ArgumentOutOfLatinLettersAndNumbersRangeException();
                }
                _type = value;
            } 
        }

        internal uint GearsNumber { get; private set; }
        internal double Performance { get; private set; }

        internal Transmission ( string theType, uint theGearsNumber, double thePerformance )
        {
            Type = theType;
            GearsNumber = theGearsNumber;
            Performance = thePerformance;
        }

        internal Transmission ( Transmission theTransmission )
        {
            Type = theTransmission.Type;
            GearsNumber = theTransmission.GearsNumber;
            Performance = theTransmission.Performance;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(Type);
            outString.AppendWithDelimiter(GearsNumber.ToString());
            outString.AppendWithDelimiter(Performance.ToString());
            return outString.ToString();
        }
    }
}
