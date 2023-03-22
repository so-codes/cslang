using System;
public class PoopException : Exception
{
    public PoopException(string message) : base(message)
    {
        Console.WriteLine("PoopException: {0}", message);
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            throw new PoopException("Poop!");
        }
        catch (PoopException e)
        {
            Console.WriteLine("Caught PoopException: {0}", e.Message);
        }
    }
}