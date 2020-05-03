using CarPark.Entities.Spares;
using System.Text;

namespace CarPark.Entities.Cars
{
    internal abstract class Vehicle
    {
        internal Engine Engine { get; private set; }
        internal Chassis Chassis { get; private set; }
        internal Transmission Transmission { get; private set; }

        internal Vehicle ( Engine theEngine, Chassis theChassis, Transmission theTransmission )
        {
            Engine = new Engine(theEngine);
            Chassis = new Chassis(theChassis);
            Transmission = new Transmission(theTransmission);
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(Engine.ToString());
            outString.AppendWithDelimiter(Chassis.ToString());
            outString.AppendWithDelimiter(Transmission.ToString());
            return outString.ToString();
        }
    }
}
