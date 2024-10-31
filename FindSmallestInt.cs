// RESULT:  Given an array of integers your solution should find the smallest integer.
// PSUEDOCODE:  Use the Min method to return the smallest integer in the array.

using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      return args.Min();
    }
}