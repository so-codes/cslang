// Write a console app that accepts 4 int numbers from user and display product of 4 numbers

using System; 

public class Program {

  public static void Main(string[] args)
  {
      int a, b, c, d;
      Console.WriteLine("Enter Number 1:");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Number 2:");
      b = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Number 3:");
      c = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Number 4:");
      d = int.Parse(Console.ReadLine());

      Console.WriteLine("Product Of Numbers is " + a * b * c * d);
  }
}