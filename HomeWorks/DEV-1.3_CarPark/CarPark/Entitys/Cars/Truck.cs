using CarPark.Entitys.Spares;
using System.Text;

namespace CarPark.Entitys.Cars
{
    internal class Truck : Vehicle
    {
        internal double Height;

        internal Truck ( Engine theEngine, Chassis theChassis, Transmission theTransmission, double theHeight )
            : base(theEngine, theChassis, theTransmission)
        {
            Height = theHeight;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(base.ToString());
            outString.AppendWithDelimiter(Height.ToString());
            return outString.ToString();
        }
    }
}
