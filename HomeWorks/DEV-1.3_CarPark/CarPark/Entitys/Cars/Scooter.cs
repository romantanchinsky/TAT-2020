using CarPark.Entitys.Spares;
using System.Text;

namespace CarPark.Entitys.Cars
{
    class Scooter : BaseCar
    {
        internal ulong Weight { get; set; }

        internal Scooter ( Engine theEngine, Chassis theChassis, Transmission theTransmission, ulong theWeight )
            : base(theEngine, theChassis, theTransmission)
        {
            Weight = theWeight;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(base.ToString());
            outString.AppendWithDelimiter(Weight.ToString());
            return outString.ToString();
        }
    }
}
