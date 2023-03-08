// Create pattern
// 1
// 2 3
// 4 5 6 
// 7 8 9 10

using System; 

public class Program {

  public static void Main(string[] args)
  {
    int i, j, k = 1, num;
    Console.WriteLine("Enter the limit: ");
    num = Convert.ToInt32(Console.ReadLine());
    for (i = 1; i <= num; i++)
    {
        for (j = 1; j <= i; j++)
        {
            Console.Write(" " + k);
            k++;
        }
        Console.WriteLine("\n");
    }
  }
}