using System;

namespace CarPark
{
    public class ProductException : Exception
    {
        public const string DEFAULT_MESSAGE = "This factory does not produce this product";

        public ProductException(string message = DEFAULT_MESSAGE)
            : base(message)
        { }
    }
}