using Converter.Entitys.Converters;

namespace Converter.Entitys.Factory
{
    class ConverterCreator : IConverterCreator
    {
        public IConverter CreateLengthConverter()
        {
            return new LengthConverter();
        }

        public IConverter CreateTemperatureConverter()
        {
            return new TemperatureConverter();
        }
    }
}
