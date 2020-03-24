using System;

namespace CarPark.Exceptions
{
    public class ArgumentOutOfLatinLettersAndNumbersRangeException : ArgumentOutOfRangeException
    {
        public const string EXCEPTION_MESSAGE = "Only latin letters or numbers can be used";
        public ArgumentOutOfLatinLettersAndNumbersRangeException ()
            : base (EXCEPTION_MESSAGE)
        { }
    }
}
