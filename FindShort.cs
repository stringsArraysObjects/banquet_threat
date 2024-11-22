// RESULT:  Given a string of words, return the length of the shortest word(s).

using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(' ').Min(x => x.Length);
  }
}