// RESULT: return a "Yes" string for true, or a "No" string for false.
//PSEUDOCODE: Use a ternary operator to evaluate the variable, then
//            provide the correct response. 

using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
    return word ? "Yes" : "No";
  }
}