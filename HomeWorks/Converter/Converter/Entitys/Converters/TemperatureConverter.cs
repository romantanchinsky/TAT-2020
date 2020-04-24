using Converter.Enums;
using System;

namespace Converter.Entitys.Converters
{
    class TemperatureConverter : IConverter
    {
        private const double FIRST_COEFFICIENT = 32.0,
                             SECOND_COEFFISIENT = 1.8;
        public const string ARGUMENT_EXCEPTION_MESSAGE = "convert method not found";

        private double ConvertFahrenheitToCelsius(double FahrenheitTemperature)
        {
            return ( FahrenheitTemperature - FIRST_COEFFICIENT ) / SECOND_COEFFISIENT;
        }

        private double ConvertCelsiusToFahrenheit(double CelsiusTemperature)
        {
            return CelsiusTemperature * SECOND_COEFFISIENT + FIRST_COEFFICIENT;
        }

        public double Convert(double temperature, ConvertNames convertName)
        {
            switch (convertName)
            {
                case ConvertNames.FC:
                    return ConvertFahrenheitToCelsius(temperature);
                case ConvertNames.CF:
                    return ConvertCelsiusToFahrenheit(temperature);
            }
            throw new ArgumentException(ARGUMENT_EXCEPTION_MESSAGE);
        }

    }
}
