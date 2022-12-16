// Write a program in c# to perform function overloading to swap 2 int nums and 2 float numbers using call by reference


using System; 
public class Program
{
public static void swapInt(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    public static void swapFloat(ref float num3, ref float num4)
    {
        float temp = num3;
        num3 = num4;
        num4 = temp;
    }

    static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 20;
        Console.Write("\nBefore Swapping : ");
        Console.Write("\nFirst Number : " + n1);
        Console.Write("\nSecond Number : " + n2);
        Program.swapInt(ref n1,ref n2);
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + n1);
        Console.Write("\nSecond Number : " + n2);

        float n3 = 2.5f;
        float n4 = 3.7f;

        Console.Write("\nBefore Swapping : ");
        Console.Write("\nFirst Number : " + n3);
        Console.Write("\nSecond Number : " + n4);
        Program.swapFloat(ref n3,ref n4);
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + n3);
        Console.Write("\nSecond Number : " + n4);
        Console.Read();
    }
}