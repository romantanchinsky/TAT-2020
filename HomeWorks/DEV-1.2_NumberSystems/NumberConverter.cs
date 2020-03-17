using System;
using System.Text;
using System.Collections.Generic;

namespace DEV_1._2_NumberSystems
{
    internal class NumberConverter
    {
        public const string EXCEPTION_CONVERT_MESSAGE = "Cant convert elements > 19";
        public const string EXCEPTION_BASE_SYSTEM_MESSAGE = "Incorrect base system value";

        protected const char ZERO = '0';

        /// <summary>
        /// method converts a decimal number to a number in another number system from 2 to 20, represented by an array
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseSystem"></param>
        /// <returns>a string encapsulating a number in the number system from 2 to 20</returns>
        internal string Convert ( int number, uint baseSystem )
        {
            if ( baseSystem < 2 || baseSystem > 20 ) { throw new ArgumentOutOfRangeException(EXCEPTION_BASE_SYSTEM_MESSAGE); }
            if ( baseSystem == 10 ) { return number.ToString(); }
            List<uint> result = new List<uint>();
            bool isNegative;
            uint newNumber;
            if ( number < 0 )
            {
                newNumber = (uint)(number * -1);
                isNegative = true;
            }
            else
            {
                newNumber = (uint)( number );
                isNegative = false;
            }
            for ( int i = 0; newNumber != 0 ; i++)
            {
                result.Add(newNumber % baseSystem);
                newNumber /= baseSystem;
            }
            
            return ConvertArray(result.ToArray(), isNegative);
        }

        protected string ConvertArray ( uint [] number, bool isNegative )
        {
            StringBuilder outString = new StringBuilder();
            if ( isNegative ) { outString.Append('-'); }
            for ( int i = number.Length - 1; i >= 0; i-- )
            {
                outString.Append(ConvertElement(number [ i ]));
            }
            return outString.ToString();
        }

        /// <summary>
        /// converts number from 0 to 19 to correct char symbol
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        protected char ConvertElement ( uint element )
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
