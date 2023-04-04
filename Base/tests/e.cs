using System;

public class Program {
  
  public static void main(String[] args)
  {
    int n1 = 0, n2 = 1 , n3 , i, number;
    Console.Write("Enter the number :");
    number = int.Parse(Console.ReadLine());
    Console.Write(n1 + " " + n2 + " ");
    for(i = 2; i < number; ++i){
      n3 = n1 + n2;
      Console.Write(n3 + " ");
      n1 = n2;
      n2 = n3;
    }
    Console.WriteLine("");
  }
}