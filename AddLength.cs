//PARAMETERS:  String will have at least one element; 
//             words will always be separated by a space.
//RESULT: write a function that takes a String and 
//        returns an Array/list with the length of 
//        each word added to each element. 
//EXAMPLE:  "apple ban" --> ["apple 5", "ban 3"]
//PSEUDOCODE: Use the split method create a substring based on a the space delimiter,
//           Use the Select method to apply a function to each substring in the collection. 
//           Use the ToArray method to convert the collection of elements to a List/Array. 



using System.Linq;

public class Kata
{
  public static string[] AddLength(string str)
  {
    /*
    string[] words = str.Split(' ');
    
    for (int i = 0; i < words.Length; i++)
    {
      words[i] = words[i] + " " + words[i].Length;
    }
    
    return words;
    */
    
    return str.Split(' ').Select(word => word + " " + word.Length).ToArray();
  }
}