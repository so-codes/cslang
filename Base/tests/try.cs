using System;
class Program {
  public static void main(){
    int number , sum = 0;
    Coonsole.WriteLine("Enter number: ");
    number = int.Parse(Console.ReadLine());

    for(int i = 1;i<number; i++){
      if(number % i == 0){
        sum = sum + i;
      }
    }

    if(sum == number){
      Console.WriteLine("Entered number is a perfect number");
    } else {
      Console.WriteLine("Entered number is not a perfect number");
    }
  } 
}