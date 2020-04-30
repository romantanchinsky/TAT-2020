using CarPark.Entities.Spares;
using System.Text;

namespace CarPark.Entities.Cars
{
    class Scooter : Vehicle
    {
        internal double Weight { get; private set; }

        internal Scooter ( Engine theEngine, Chassis theChassis, Transmission theTransmission, double theWeight )
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
