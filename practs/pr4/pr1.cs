// perform xception handling (class Program)

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter Number 1:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2:");
        b = int.Parse(Console.ReadLine());
        try
        {
            c = a / b;
            Console.WriteLine("Division is " + c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Division by zero is not possible");
        }
    }
}