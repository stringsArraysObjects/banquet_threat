// PARAMETERS:  The number can be negative already, in which case no change is required.
// RESULT:  given a number and have to make it negative.
//PSEUDOCODE: use a tenary operator to test the value of the variable,
//            and return the results based on condition's outcome.


using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    return -Math.Abs(number);
  }
}

using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    return number < 0 ? number : -number;
  }
}