// RESULT:   Create a function that squares each number passed into it and then sums the results together.

using System.Linq;
public static class Kata
{
  public static int SquareSum(int[] n) => n.Sum(i => i * i);
}