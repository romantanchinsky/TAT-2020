using System;
using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Transmission
    {
        private const string EXCEPTION_MESSAGE = "Only latin letters or numbers can be used";

        private string _type;
        internal string Type
        {
            get => _type;
            set
            {
                Checker checker = new Checker();
                if ( !checker.IsLatinLettersAndNumbers(value) )
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
                }
                _type = value;
            } 
        }

        internal uint GearsNumber { get; set; }
        internal double Performance { get; set; }

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
