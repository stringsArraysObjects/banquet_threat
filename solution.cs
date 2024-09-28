// using System;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     throw new NotImplementedException("TODO: Kata.Solution(string) => string");
//   }
// }
// RESULT: reverse a string
// PSEUDOCODE: Convert to a character array: Use the string.ToCharArray() method to convert the string to a character array. 
//             Reverse the array
//             Convert back to a string.


using System;
using System.Linq;

public static class Kata
{
  public static string Solution(string str) 
  {
     return new string(str.ToCharArray().Reverse().ToArray());
  }
}