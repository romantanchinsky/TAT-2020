using CarPark.Entitys.Spares;
using System.Text;

namespace CarPark.Entitys.Cars
{
    internal abstract class Vehicle
    {
        internal Engine Engine { get; set; }
        internal Chassis Chassis { get; set; }
        internal Transmission Transmission { get; set; }

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
