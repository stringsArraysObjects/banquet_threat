// RESULT:  return the middle character(s) of the string.
// EXAMPLE: "test" --> "es"
//          "testing" --> "t"


public class Kata
{
    public static string GetMiddle(string s)
    {
        return string.IsNullOrEmpty(s)
            ? s
            : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
    }
}