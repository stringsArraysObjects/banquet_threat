// RESULT:  function that counts the number of sheep present in the array (true means present).


using System;
using System.Linq;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Count(s => s);
  }
}