using System;
using System.Text;
using System.Collections.Generic;

namespace DEV_1._2_NumberSystems
{
    internal class NumberConverter
    {
        public const string EXCEPTION_BASE_SYSTEM_MESSAGE = "Incorrect base system value";

        public const int LOWER_SYSTEM_BOUND = 2;
        public const int UPPER_SYSTEM_BOUND = 20;
        protected const char ZERO = '0';
        protected const char DIFFERENCE_BETWEEN_INT_CHAR_LATERS = (char)55;


        /// <summary>
        /// method converts a decimal number to a number in another number system from 2 to 20, represented by an array
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseSystem"></param>
        /// <returns>a string encapsulating a number in the number system from 2 to 20</returns>
        internal string Convert ( int number, uint baseSystem )
        {
            if ( baseSystem < LOWER_SYSTEM_BOUND || baseSystem > UPPER_SYSTEM_BOUND ) 
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_BASE_SYSTEM_MESSAGE); 
            }
            if ( baseSystem == 10 )
            {
                return number.ToString(); 
            }
            List<uint> result = new List<uint>();
            bool isNegative;
            uint newNumber;
            if ( number < 0 )
            {
                newNumber = (uint)( number * -1 );
                isNegative = true;
            }
            else
            {
                newNumber = (uint)( number );
                isNegative = false;
            }
            for ( int i = 0; newNumber != 0 ; i++ )
            {
                result.Add(newNumber % baseSystem);
                newNumber /= baseSystem;
            }
            
            return ConvertArray(result.ToArray(), isNegative);
        }

        protected string ConvertArray ( uint [] number, bool isNegative )
        {
            StringBuilder outString = new StringBuilder();
            if ( isNegative ) 
            {
                outString.Append('-'); 
            }
            for ( int i = number.Length - 1; i >= 0; i-- )
            {
                outString.Append(ConvertElement(number [ i ]));
            }
            return outString.ToString();
        }

        protected char ConvertElement ( uint element )
        {
            if ( element < 10 ) 
            {
                return (char)( element + ZERO ); 
            }
            return (char)( element + DIFFERENCE_BETWEEN_INT_CHAR_LATERS );
        }
    }
}
