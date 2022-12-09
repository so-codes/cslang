// // Create an app that acc stud id name
// , course name and percentage
// from student using method getdata, create another method display to display the same

using System; 

public class Program {

  public static void Main(string[] args)
  {
      string StudName, CourseName;
      int StudID, TotalMks;
  
      void GetData()
      {
          Console.WriteLine("Enter Student ID:");
          StudID = int.Parse(Console.ReadLine());
  
          Console.WriteLine("Enter Student Name:");
          StudName = Console.ReadLine();
  
          Console.WriteLine("Enter Course Name:");
          CourseName = Console.ReadLine();
  
          Console.WriteLine("Enter Total Marks:");
          TotalMks = int.Parse(Console.ReadLine());
      }
  
      void Display()
      {
          Console.WriteLine("Student ID : " + StudID);
          Console.WriteLine("Student Name : " + StudName);
          Console.WriteLine("Course Name : " + CourseName);
          Console.WriteLine("Total Marks : " + TotalMks);
      }
      static void Pr4(string[] args)
      {
          pr4 student = new pr4();
          student.GetData();
          student.Display();
      }
  }
}