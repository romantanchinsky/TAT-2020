using System;

namespace DEV_1._2_NumberSystems
{
    class Program
    {
        static void Main ( string [] args )
        {
            string exitString = "y";
            int number;
            uint numberSystem;
            NumberConverter numberConverter = new NumberConverter();
            while ( exitString == "y" )
            {
                while ( true )
                {
                    Console.WriteLine("Enter decimal number");
                    if ( int.TryParse(Console.ReadLine(), out number) )
                    {
                        break; 
                    }
                }
                while ( true )
                {
                    Console.WriteLine("Enter number system");
                    if ( uint.TryParse(Console.ReadLine(), out numberSystem) && numberSystem >= 2 && numberSystem <= 20 )
                    {
                        break; 
                    }
                }
                Console.WriteLine(numberConverter.Convert(number, numberSystem));
                Console.WriteLine("Do you what to contuine (y/n): ");
                exitString = Console.ReadLine();
            }
        }
    }
}
