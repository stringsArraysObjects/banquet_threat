// RESULT: Make multiple functions that will return the sum, 
//         difference, modulus, product, quotient, and the 
//         exponent respectively.
// PSEUDOCODE: use an expression lambda that has an expression as its body.




using System;

public static class Kata
{
  public static int Add(int a, int b) => a + b;
  public static int Subt(int a, int b) => a - b;
  public static int Multiply(int a, int b) => a * b;
  public static int Divide(int a, int b) => b == 0 ? throw new ArgumentException() : a / b;
  public static int Mod(int a, int b) => a % b;
  public static int Exponent(int a, int b) => (int)Math.Pow(a, b);
}