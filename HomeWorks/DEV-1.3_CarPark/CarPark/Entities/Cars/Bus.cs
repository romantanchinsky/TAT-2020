using CarPark.Entities.Spares;
using System.Text;

namespace CarPark.Entities.Cars
{
    class Bus : Vehicle
    {
        internal uint SeatsNumber { get; private set; }

        internal Bus ( Engine theEngine, Chassis theChassis, Transmission theTransmission, uint theSeatsNumber )
            : base(theEngine, theChassis, theTransmission)
        {
            SeatsNumber = theSeatsNumber;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(base.ToString());
            outString.AppendWithDelimiter(SeatsNumber.ToString());
            return outString.ToString();
        }
    }
}
