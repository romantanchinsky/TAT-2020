﻿using System;

namespace DEV_2_ConsoleString
{
    public class StringEstimator
    {
        public const string ARGUMENT_NULL_EXCEPTINO_MESSSAGE = "Argument == null";
        public int GetMaxSequence ( string theString )
        {
            if ( theString == null ) { throw new ArgumentNullException(ARGUMENT_NULL_EXCEPTINO_MESSSAGE); }
            if ( theString.Length > 0  )
            {
                int answer = 1, temp = 1;
                for ( int i = 1; i < theString.Length; i++ )
                {
                    if ( theString [ i ] != theString [ i - 1 ] )
                    {
                        if ( answer < temp ) { answer = temp; }
                        temp = 1;
                    }
                    else { temp++; }
                }
                return answer > temp ? answer : temp;
            }
            return 0;
        }
    }
}
