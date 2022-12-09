// create and app to gget char from user and check if it is vowel por not 

using System; 

public class Program {

  public static void Main(string[] args)
  {
    Console.WriteLine("Enter Character:");
    char ch = Convert.ToChar(Console.ReadLine());
  
    switch (ch)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
        case 'A':
        case 'E':
        case 'I':
        case 'O':
        case 'U':
            Console.WriteLine("Entered char is a vowel");
            break;
        default:
            Console.WriteLine("Its not a vowel aka its a consonent");
            break;
    }
  }
}