using System; 

public class Program {

  public static void Main(string[] args)
  {
    int i, j, e = 0 , o = 1, num;
    Console.WriteLine("Enter the limit: ");
    num = Convert.ToInt32(Console.ReadLine());
    for (i = 1; i <= num; i++)
    {
        for (j = 1; j <= i; j++)
        {
            if(j % 2 == 0)
            {
                Console.Write(e + " ");
            } else
            {
                Console.Write(o + " ");
            }
        }
        Console.WriteLine("\n");
    }
  }
}