using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Engine
    {
        internal ulong Power { get; set; }
        internal ulong Capacity { get; set; }
        internal string Type { get; set; }
        internal string SerialNumber { get; set; }

        internal Engine ( ulong thePower, ulong theCapacity, string theType, string theSerialNumber )
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
