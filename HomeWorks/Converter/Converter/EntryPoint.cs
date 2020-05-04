using Converter.Entitys.Factory;
using Converter.Enums;
using System;

namespace Converter
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length == 2 && double.TryParse(args[0], out double value) && Enum.TryParse(args[1], out ConvertNames convertName))
            {
                ConverterCreator creator = new ConverterCreator();
                if (convertName == ConvertNames.CF || convertName == ConvertNames.FC)
                {
                    Console.WriteLine(creator.CreateTemperatureConverter().Convert(value, convertName));
                    return;
                }
                if (convertName == ConvertNames.FM || convertName == ConvertNames.MF)
                {
                    Console.WriteLine(creator.CreateLengthConverter().Convert(value, convertName));
                    return;
                }
            }
            Console.WriteLine("incorrect arguments");
        }
    }
}
