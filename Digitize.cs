// RESULT:  Given a random non-negative number, you have to 
//          return the digits of this number within an array in reverse order.


using System;
using System.Collections.Generic;
using System.Linq;

    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
        }
    }