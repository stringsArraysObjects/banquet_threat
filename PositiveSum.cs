// RESULT: return the sum of all of the positives ones.
// using System;
// public class Kata
// {
//   public static int PositiveSum(int[] arr)
//   {
   
//     return 0;
//   }
// }

using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
  return arr.Sum(c => (c < 0 ? 0 : c));
  }
}

using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
            int sum = 0;

            if (arr != null)
            {
                foreach (int i in arr)
                {
                    if (i > 0)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += 0;
                    }
                }
                return sum;
            }
            return 0;
        }
}