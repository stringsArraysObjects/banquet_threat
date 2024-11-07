//RESULT: Return the the highest and lowest number.

using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
  }
}