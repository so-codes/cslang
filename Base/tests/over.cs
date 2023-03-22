using System; 

public class Program {

    public static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        int x = 10, y = 20;
        Console.WriteLine("x = {0}, y = {1}", x, y);
        Swap(x, y);
        Console.WriteLine("x = {0}, y = {1}", x, y);
        Swap(ref x, ref y);
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}