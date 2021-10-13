using System;

class Program {
  public static int IntegerPower(int num1, int num2)
  {
  int mult = 1;
  int end = 1;
  while(mult<=num2)
  {
    end = (end * num1);
    mult++;
  }
  return end;
  }
  
  public static void Main (string[] args) 
  {
    Console.WriteLine("Provide integer value for base:");
    int num1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Provide positive integer value for exponent:");
    int num2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num1 + " to the power of " + num2 + " equals:");
    Console.WriteLine(IntegerPower(num1,num2));
  }
}