// RESULT:  Create a function that accepts a string and a single character, 
//          and returns an integer of the count of occurrences the 2nd 
//          argument is found in the first one.
// EXAMPLE: ("Hello", 'o')  =>  1
// PSEUDOCODE:  use the where method to filter the string and return
//              only the char represented by letter. Use the count method
//              to return the count of occurences.
using System.Linq;

class Kata
{
    public static int StrCount(string str, char letter)
    {
        return str.Where(x => x == letter).Count();
    }
}