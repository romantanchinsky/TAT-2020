using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace DEV_1._2_NumberSystems
{
    public class SystemConverter
    {
        public const string EXCEPTION_CONVERT_MESSAGE = "Cant convert elements > 19";

        protected const char ZERO = '0';

        internal string Convert ( int number, int baseSystem )
        {
            List<int> result = new List<int>();
            bool isNegative = false;
            if ( number < 0 )
            {
                number *= -1;
                isNegative = true;

            }
            for ( int i = 0; number != 0 ; i++)
            {
                result.Add(number % baseSystem);
                number /= baseSystem;
            }
            return ConvertArray(result.ToArray(), isNegative);
        }

        protected string ConvertArray ( int [] number, bool isNegative )
        {
            StringBuilder outString = new StringBuilder();
            if ( isNegative ) { outString.Append('-'); }
            for ( int i = number.Length - 1; i >= 0; i-- )
            {
                outString.Append(ConvertElement(number [ i ]));
            }
            return outString.ToString();
        }

        protected char ConvertElement ( int element )     // converts number from 0 to 19 to correct char symbol
        {
            if ( element < 10 ) { return (char)(element + ZERO); }
            switch ( element )
            {
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                case 16:
                    return 'G';
                case 17:
                    return 'H';
                case 18:
                    return 'I';
                case 19:
                    return 'J';
            }
            throw new ArgumentOutOfRangeException(EXCEPTION_CONVERT_MESSAGE);
        }
    }
}
