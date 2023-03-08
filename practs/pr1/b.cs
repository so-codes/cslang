// Create an application to demonstrate basic string operations
using System;

public class Program {

  public static void Main(string[] args)
  {
    string s1 = "Hello";
    string s2 = "World";
    string s3 = s1 + " " + s2;
    Console.WriteLine(s3);
    Console.WriteLine(s3.Length);
    Console.WriteLine(s3.ToUpper());
    Console.WriteLine(s3.ToLower());
    Console.WriteLine(s3.Substring(3));
    Console.WriteLine(s3.Substring(3, 4));
    Console.WriteLine(s3.IndexOf("o"));
    Console.WriteLine(s3.IndexOf("o", 4));
  }
}
