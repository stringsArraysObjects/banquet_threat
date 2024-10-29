// RESULT:  create a function that removes the first and last characters of a string.
// PSEUDOCODE:  Because we are using a string can't use slice instead use the Substring method.
//              Which extracts a substring starting at char position 1 and ends 1 char before end of string.


using System;

        public class Kata
        {
            public static string Remove_char(string s)
            {
                return s.Substring(1,(s.Length - 2));
            }
        }