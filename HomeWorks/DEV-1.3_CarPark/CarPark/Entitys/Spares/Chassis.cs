using CarPark.Exceptions;
using System.Text;

namespace CarPark.Entitys.Spares
{
    internal class Chassis
    {
        internal uint WheelsNumber  { get; set; }

        private string _number;
        internal string Number
        {
            get => _number;
            set
            {
                Checker checker = new Checker();
                if ( !checker.IsLatinLettersAndNumbers(value) )
                {
                    throw new ArgumentOutOfLatinLettersAndNumbersRangeException();
                }
                _number = value;
            }
        }

        internal double PermissibleLoad { get; set; }

        internal Chassis ( uint theWheelsNumber, string theNumber, double thePermissibleLoad )
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
