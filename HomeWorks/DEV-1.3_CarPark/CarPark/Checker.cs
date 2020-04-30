using System;

namespace CarPark
{
    internal class Checker
    {
        private const char SYMBOL_ZERO = '0';
        private const char SYMBOL_NINE = '9';
        private const char SYMBOL_A_LOVERCASE = 'a';
        private const char SYMBOL_Z_LOVERCASE = 'z';

        /// <summary>
        /// checks the string for characters other than numbers and latin letters
        /// </summary>
        /// <param name="checkedString"></param>
        /// <returns></returns>
        internal bool IsLatinLettersAndNumbers(string checkedString)
        {
            if ( !String.IsNullOrEmpty(checkedString) )
            {
                foreach ( var symbol in checkedString.ToLower() )
                {
                    if ( !(symbol >= SYMBOL_ZERO && symbol <= SYMBOL_NINE) && !(symbol >= SYMBOL_A_LOVERCASE && symbol <= SYMBOL_Z_LOVERCASE) )
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
