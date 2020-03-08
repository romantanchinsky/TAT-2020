using System;
namespace DEV_2_ConsoleString
{
    class EntryPoint
    {
        static void Main ( string [] args )
        {
            Console.WriteLine("Enter string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine(GetMaxSequence(inputString));

        }

        static int GetMaxSequence ( string theString )
        {
            if ( theString.Length == 0 ) 
            { 
                return 0; 
            }

            int answer = 1, temp = 1;
            for ( int i = 1; i < theString.Length; i++ )
            {
                if ( theString [ i ] != theString [ i - 1 ] )
                {
                    if ( answer < temp )
                    {
                        answer = temp; 
                    }
                    temp = 1;
                }
                else 
                {
                    temp++;
                }
            }

            return answer > temp ? answer : temp;
        }
    }
}
