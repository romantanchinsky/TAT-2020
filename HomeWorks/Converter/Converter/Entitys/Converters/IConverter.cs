using Converter.Enums;

namespace Converter.Entitys.Converters
{
    interface IConverter
    {
        double Convert(double value, ConvertNames convertName);
    }
}
