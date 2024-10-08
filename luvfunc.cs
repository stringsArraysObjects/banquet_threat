// RESULT:  Write a function that will take the number of
//           petals of each flower and return true if they 
//           are in love and false if they aren't.
// PSEUDOCODE:  Use a boolean expression to check if the remainder 
//              of dividing flower1 and flower2 by 2 are different, resulting in
//              a true or false value based on the comparison with the "not equal to" operator (!=)


using System;

public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        { 
          return flower1 % 2 != flower2 % 2 ;
        }
    }