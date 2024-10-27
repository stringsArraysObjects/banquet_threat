// RESULT:  Take a list of non-negative integers and strings
//           and returns a new list with the strings filtered out.

using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> results = new List<int>();
      
      foreach(var item in listOfItems)
      {
        if(item is int)
        {
          results.Add((int)item);
        }
      }
      
      return results;
   }
}