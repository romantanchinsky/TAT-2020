using Converter.Enums;
using System;

namespace Converter.Entitys.Converters
{
    class LengthConverter : IConverter
    {
        private const double COEFFICIENT = 3.281;
        public const string ARGUMENT_EXCEPTION_MESSAGE = "convert method not found";

        private double ConvertMeterToFoots(double meterLength)
        {
            return meterLength * COEFFICIENT;
        }

        private double ConvertFootsToMeter(double footsLength)
        {
            return footsLength / COEFFICIENT;
        }

        public double Convert(double length, ConvertNames convertName)
        {
            switch (convertName)
            {
                case ConvertNames.MF:
                    return ConvertMeterToFoots(length);
                case ConvertNames.FM:
                    return ConvertFootsToMeter(length);
            }
            throw new ArgumentException(ARGUMENT_EXCEPTION_MESSAGE);
        }

    }
}
