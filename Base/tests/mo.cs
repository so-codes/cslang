// Function Overloading
// Overloading is when you have multiple methods with the same name but different parameters
// This is useful when you want to do the same thing but with different parameters
// For example, you can have a method that takes a string and one that takes an int
// You can also have a method that takes a string and an int and one that takes an int and a string

using System;

public class Program {
    static void Main(string[] args) {
        // Call the method with a string
        Print("Hello World!");
        // Call the method with an int
        Print(5);
        // Call the method with a string and an int
        Print("Hello World!", 5);
        // Call the method with an int and a string
        Print(5, "Hello World!");
    }

    // Method that takes a string
    static void Print(string message) {
        Console.WriteLine(message);
    }

    // Method that takes an int
    static void Print(int number) {
        Console.WriteLine(number);
    }

    // Method that takes a string and an int
    static void Print(string message, int number) {
        Console.WriteLine(message + " " + number);
    }

    // Method that takes an int and a string
    static void Print(int number, string message) {
        Console.WriteLine(number + " " + message);
    }
}