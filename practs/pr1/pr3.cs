// to accept num from user and check if num is perfect num or not

using System; 

public class Program {

  public static void Main(string[] args)
  {
      int number, sum = 0;
      Console.Write("enter the Number");
      number = int.Parse(Console.ReadLine());
      for (int i = 1; i < number; i++) {
          if (number % i == 0) {
              sum = sum + i;
          }
      }
      if (sum == number) {
          Console.WriteLine("\nEntered number is a perfect number");
          Console.ReadLine();
      } else {
          Console.WriteLine("\nEntered number is not a perfect number");
          Console.ReadLine();
      }
      Console.ReadKey();
  }
}