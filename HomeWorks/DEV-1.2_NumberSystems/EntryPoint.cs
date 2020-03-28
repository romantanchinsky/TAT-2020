using System;

namespace DEV_1._2_NumberSystems
{
    class EntryPoint
    {
        static void Main ( string [] args )
        {
            if ( args.Length == 2 )
            {
                NumberConverter numberConverter = new NumberConverter();

                if ( int.TryParse(args [ 0 ], out int number) && uint.TryParse(args [ 1 ], out uint numberSystem) && numberSystem >= 2 && numberSystem <= 20 )
                {
                    Console.WriteLine(numberConverter.Convert(number, numberSystem));
                    return;
                }
            }
            Console.WriteLine("The program should accept the decimal number and the base of the new number system (from 2 to 20)");
        }
    }
}
