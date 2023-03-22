// C# Destructors
// C# Destructors are called when an object is destroyed. They are called
// automatically by the garbage collector, and can also be called explicitly
// by the programmer. Destructors are used to clean up resources that are
// allocated by the object. Destructors are declared with the ~ prefix.
// Destructors cannot be overloaded, and cannot have any parameters.
// Destructors cannot be called directly, but they can be called indirectly
// by calling the Dispose() method on the object. The Dispose() method is
// defined in the IDisposable interface, and is called by the garbage
// collector when an object is destroyed. The Dispose() method is used to
// clean up resources that are allocated by the object. The Dispose() method
// is declared with the void return type, and can have parameters.
// The Dispose() method can be called directly, and can be overloaded.

using System;

class Test : IDisposable
{
    // The Dispose() method.
    public void Dispose()
    {
        // Call the destructor.
        GC.SuppressFinalize(this);
    }

    // The destructor.
    ~Test()
    {
        // Clean up resources.
        Console.WriteLine("Destructor called.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Test class.
        Test test = new Test();

        // Call the Dispose() method on the test object.
        test.Dispose();
    }
}