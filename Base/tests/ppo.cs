using System;

public class Program
{
  public static void Main()
  {
    //declaring variables without assigning values
    float area, perimeter;
    //passing multiple variables to a method using 'out' keyword
    Calculate(5, 10, out area, out perimeter);
    //displaying the result
    Console.WriteLine("The area of rectangle is: {0}", area);
    Console.WriteLine("The perimeter of rectangle is: {0}", perimeter);
    Console.ReadLine();
  }
  //method taking length & breadth & it will return area and perimeter of rectangle
  public static void Calculate(int length, int breadth, out float area, out float perimeter)
  {
    area = length * breadth;
    perimeter = 2 * (length + breadth);
  }

}