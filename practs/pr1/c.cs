//  Create an application for data of Student

using System;

public class Program {

  public static void Main(string[] args)
  {
    string name;
    int rollno;
    float marks;
    Console.Write("Enter the name of student: ");
    name = Console.ReadLine();
    Console.Write("Enter the roll no of student: ");
    rollno = int.Parse(Console.ReadLine());
    Console.Write("Enter the marks of student: ");
    marks = float.Parse(Console.ReadLine());
    Console.WriteLine("Name of student is: " + name);
    Console.WriteLine("Roll no of student is: " + rollno);
    Console.WriteLine("Marks of student is: " + marks);
  }
}
