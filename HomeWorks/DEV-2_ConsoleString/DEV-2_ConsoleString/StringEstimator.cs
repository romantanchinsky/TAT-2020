using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2_ConsoleString
{
    class StringEstimator
    {
        public int GetMaxSequence ( string theString )
        {
            if ( theString?.Length > 0  )
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
