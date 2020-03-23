using CarPark.Entitys.Spares;
using System.Text;

namespace CarPark.Entitys.Cars
{
    internal class PassengerCar : BaseCar
    {
        internal string Color { get; set; }

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
