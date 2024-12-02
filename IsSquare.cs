
// RESULT:  Given an integral number, determine if it's a square number.
using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    return Math.Sqrt(n) % 1 == 0;
  }
}