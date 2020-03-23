using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Chassis
    {
        internal uint WheelsNumber  { get; set; }
        internal string Number { get; set; }
        internal ulong PermissibleLoad { get; set; }

        internal Chassis ( uint theWheelsNumber, string theNumber, ulong thePermissibleLoad )
        {
            WheelsNumber = theWheelsNumber;
            Number = theNumber;
            PermissibleLoad = thePermissibleLoad;
        }
        
        internal Chassis ( Chassis theChassis )
        {
            WheelsNumber = theChassis.WheelsNumber;
            Number = theChassis.Number;
            PermissibleLoad = theChassis.PermissibleLoad;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(WheelsNumber.ToString());
            outString.AppendWithDelimiter(Number);
            outString.AppendWithDelimiter(PermissibleLoad.ToString());
            return outString.ToString();
        }
    }
}
