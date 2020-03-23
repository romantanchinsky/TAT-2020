﻿using System;

namespace CarPark
{
    internal class Checker
    {
        private const char SYMBOL_ZERO = '0';
        private const char SYMBOL_NINE = '9';
        private const char SYMBOL_A_CAPITAL = 'A';
        private const char SYMBOL_Z_CAPITAL = 'Z';
        private const char SYMBOL_A_LOVERCASE = 'a';
        private const char SYMBOL_Z_LOVERCASE = 'z';

        private bool _flag = false;

        internal bool IsLatinLettersAndNumbers(string checkedString)
        {
            if ( checkedString != null && checkedString != String.Empty)
            {
                foreach ( var symbol in checkedString )
                {
                    if ( symbol >= SYMBOL_ZERO && symbol <= SYMBOL_NINE || symbol >= SYMBOL_A_CAPITAL && symbol <= SYMBOL_Z_CAPITAL || symbol >= SYMBOL_A_LOVERCASE && symbol <= SYMBOL_Z_LOVERCASE )
                    {
                        continue;
                    }
                    return _flag;
                }
                _flag = true;
            }
            return _flag;
        }
    }
}
