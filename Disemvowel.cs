// RESULT:  write a function that takes a string and return a new string with all vowels removed.
// EXAMPLE: [TestCase("What are you, a communist?", "Wht r y,  cmmnst?")]
// PSEUDOCODE:  Use the where method to filter char that are not vowels
//              Use the contains method to evaluate the where statement if true the char will be concatenated.
using System;
using System.Linq;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
  }
}