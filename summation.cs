// RESULT:  create a function that sums every number from 1 to num.
// EXAMPLE:     2 -> 3 (1 + 2)
//              8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)



using System;

public static class Kata 
{
    public static int summation(int num)
    {
      return num*(num+1)/2;
    }
}