using System;

namespace DEV_1._2_NumberSystems
{
    class Program
    {
        static void Main ( string [] args )
        {
            Invoker();
        }

        public static void Invoker ()
        {
            string exetString = "y";
            int number;
            uint numberSystem;
            while ( exetString == "y")
            {
                while ( true )
                {
                    Console.WriteLine("Enter decimal number");
                    if ( int.TryParse(Console.ReadLine(), out number) ) { break; }
                }
                while ( true )
                {
                    Console.WriteLine("Enter number system");
                    if ( uint.TryParse(Console.ReadLine(), out numberSystem) && numberSystem >= 2 && numberSystem <= 20 ) { break; }
                }
                NumberConverter numberConverter = new NumberConverter();
                Console.WriteLine(numberConverter.Convert(number, numberSystem));
                Console.WriteLine("Do you what to contuine (y/n): ");
                exetString = Console.ReadLine();
            }
        }
    }
}
