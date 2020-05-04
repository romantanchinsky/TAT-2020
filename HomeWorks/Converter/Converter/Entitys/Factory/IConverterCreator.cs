using Converter.Entitys.Converters;

namespace Converter.Entitys.Factory
{
    interface IConverterCreator
    {
        IConverter CreateTemperatureConverter();
        IConverter CreateLengthConverter();
    }
}
