using System;
namespace DEV_2_ConsoleString
{
    class EntryPoint
    {
        static void Main ( string [] args )
        {
            Console.Write("Enter string: ");
            string inputString = Console.ReadLine();
            StringEstimator stringEstimator = new StringEstimator();
            Console.WriteLine("Max Symbol Sequence = {0}", stringEstimator.GetMaxSequence(inputString));
        }
    }
}
