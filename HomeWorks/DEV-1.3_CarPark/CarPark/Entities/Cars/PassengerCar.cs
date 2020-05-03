using CarPark.Entities.Spares;
using System.Text;

namespace CarPark.Entities.Cars
{
    internal class PassengerCar : Vehicle
    {
        internal string Color { get; private set; }

        internal PassengerCar( Engine theEngine, Chassis theChassis, Transmission theTransmission, string theColor )
            : base( theEngine, theChassis, theTransmission )
        {
            Color = theColor;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(base.ToString());
            outString.AppendWithDelimiter(Color);
            return outString.ToString();
        }
    }
}
