// Create a function that takes an integer as an argument 
// and returns "Even" for even numbers or "Odd" for odd numbers.
//PSEUDOCODE: use a tenary operator to test if the number is 
//             even or odd.


using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      return number % 2 == 0 ? "Even" : "Odd";
    }
  }
}