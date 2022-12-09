// create simple application to perform ->
// find factorial , money conversion,
// temperature conversion, quadratic equation. (1 program itself)

using System; 

public class Program {

  public static void Main(string[] args)
  {
      Console.WriteLine("Enter 1 for factorial \n2 for money conversion \n3 for temperature conversion \n4 for quadratic eqn");
      int num = int.Parse(Console.ReadLine());

      switch(num)
      {
          case 1:
              Console.WriteLine("Enter a num: ");
              int ans = 0;
              int n = int.Parse(Console.ReadLine());
              for(int i = n; i >= 0; i--)
              {
                  ans = (n * (n - 1));
              }
              Console.WriteLine(ans);
              break;
          case 2:
              Console.WriteLine("Money Conversion");
              Console.WriteLine("Enter num of dollars: ");
              float dollar = float.Parse(Console.ReadLine());
              float inr = dollar * 82;
              Console.WriteLine(inr);
              break;
          case 3:
              Console.WriteLine("Enter * celcius");
              int cel = int.Parse(Console.ReadLine());
              int far = (cel * 9) / 5 + 32;
              Console.WriteLine(far);
              break;
          case 4:
              Console.WriteLine("Enter x1 cordinates");
              float x1 = float.Parse(Console.ReadLine());
              Console.WriteLine("Enter y1 cordinates");
              float y1 = float.Parse(Console.ReadLine());

              Console.WriteLine("Enter x2 cordinates");
              float x2 = float.Parse(Console.ReadLine());
              Console.WriteLine("Enter y2 cordinates");
              float y2 = float.Parse(Console.ReadLine());

              double distance = (((x2 - x1) * 2 + (y2 - y1) * 2) * 0.5);
              Console.WriteLine(distance);
              break;
      }
  }
}
