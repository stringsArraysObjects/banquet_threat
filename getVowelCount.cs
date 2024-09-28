// using System;

// public static class Kata
// {
//     public static int GetVowelCount(string str)
//     {
//         int vowelCount = 0;

//         // Your code here

//         return vowelCount;
//     }
// }
// PARAMETERS:  y is not considered a vowel for this exercise
//              
// RESULT:  Return the number (count) of vowels in the given string.
// PSEUDOCODE: Use the contains method to check for the vowels. 
//             Use the count method to iterate over the string and
//             tally the occurrances of vowels.

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}