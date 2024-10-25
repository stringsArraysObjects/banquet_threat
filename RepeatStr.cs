// RESULT:  Returns a string of s repeated exactly n times.
// PSUEDOCODE: Use the Enumerable.Repeat method to generate a sequence of s repeated n times.

namespace Solution
{
  using System;
  using System.Linq;
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return String.Concat(Enumerable.Repeat(s, n));
    }
  }
}

// other solutions
using System.Text;
namespace Solution{
  
  public static class Program {
  
    public static string RepeatStr(int n, string s) {
      return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }
  }
}