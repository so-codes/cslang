// 

using System; 

public class Book
  {
  string bname = "";
  string aname = "";
  int price = 0;

  public void getData()
  {
    Console.Write("Enter book name: ");
    bname = Convert.ToString(Console.ReadLine());
    Console.Write("Enter author name: ");
    aname = Convert.ToString(Console.ReadLine());
    Console.Write("Enter book price: ");
    price = Convert.ToInt32(Console.ReadLine());
  }

  public void display()
  {
    Console.WriteLine($"The book {bname} written by {aname} is of {price}");
  }
}

public class Program
  {
      static void Main(string[] args)
      {
    Book[] b = new Book[5];
    for(int i = 0; i <5; i++)
          {
      b[i] = new Book();
      b[i].getData();
      b[i].display();
      
          }
  }
}

