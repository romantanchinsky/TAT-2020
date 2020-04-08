using System;

namespace DEV_2_ConsoleString
{
    public class StringEstimator
    {
        public const string ARGUMENT_NULL_EXCEPTION_MESSAGE = "Argument == null";
        public int GetMaxSequence ( string checkedString )
        {
            if ( checkedString == null )
            {
                throw new ArgumentNullException(ARGUMENT_NULL_EXCEPTION_MESSAGE);
            }
            if ( checkedString.Length > 1  )
            {
                int maxLength = 1, 
                    currentLength = 1;
                for ( int i = 1; i < checkedString.Length; i++ )
                {
                    if ( checkedString [ i ] != checkedString [ i - 1 ] )
                    {
                        if ( maxLength < currentLength )
                        { 
                            maxLength = currentLength;
                        }
                        currentLength = 1;
                    }
                    else 
                    { 
                        currentLength++; 
                    }
                }
                return maxLength > currentLength ? maxLength : currentLength;
            }
            return checkedString == String.Empty ?  0 : 1;
        }
    }
}
