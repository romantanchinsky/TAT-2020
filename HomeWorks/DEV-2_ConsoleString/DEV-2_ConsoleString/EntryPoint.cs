using System;

namespace DEV_2_ConsoleString
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //if (args.Length == 1)
            //{
            //    StringEstimator stringEstimator = new StringEstimator();
            //    Console.WriteLine("Max Symbol Sequence = {0}", stringEstimator.CountMaxSequence(args[0]));
            //    return;
            //}
            //Console.WriteLine("No data entered");

            StringEstimator stringEstimator = new StringEstimator();
            Console.WriteLine("Max Symbol Sequence = {0}", stringEstimator.CountMaxConsecutiveUnequalSymbols("1234a2qgfhj"));
        }
    }
}
