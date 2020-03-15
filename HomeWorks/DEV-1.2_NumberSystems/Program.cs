using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._2_NumberSystems
{
    class Program
    {
        static void Main ( string [] args )
        {
            Invoker();
        }

        static void Invoker ()
        {
            string exetString = "y";
            int number;
            int numberSystem;
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
                    if ( int.TryParse(Console.ReadLine(), out numberSystem) && numberSystem >= 2 && numberSystem <= 20 ) { break; }
                }
                SystemConverter systemConverter = new SystemConverter();
                Console.WriteLine(systemConverter.Convert(number, numberSystem));
                Console.WriteLine("Do you what to contuine (y/n): ");
                exetString = Console.ReadLine();
            }
        }
    }
}
