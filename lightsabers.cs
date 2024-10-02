// RESULT:  accepts the name of a programmer and
//          returns the number of lightsabers owned by that person
// EXAMPLE: "anyone else" --> 0
//          "Zach" --> 18
// PSEUDOCODE:  use the contain method to determine if the string
//              is the name Zach.  





using System;

public class Kata
{
  public static int HowManyLightsabersDoYouOwn(string name)
  {
    if(name.Contains("Zach"))
    {
    return 18;
    }
    else
    {
    return 0;
    }
  }
}