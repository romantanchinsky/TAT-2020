using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Transmission
    {
        internal string Type { get; set; }
        internal uint GearsNumber { get; set; }
        internal ulong Performance { get; set; }

        internal Transmission ( string theType, uint theGearsNumber, ulong thePerformance )
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
