// RESULT:   Given a non-negative integer as an argument and return it with its digits in descending order
// EXAMPLE:  Input: 42145 Output: 54421

using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
  }
}