// Inheritance
// Inheritance is a way to reuse code. 
// It allows you to create a new class that is a modified version of an existing class. 
// The new class is called a derived class, and the existing class is called a base class. 
// The derived class inherits all the members of the base class, and can add its own members as well. 
// Inheritance is a way to express an "is-a" relationship between classes. 
// For example, a Rectangle is a Shape, so Rectangle can inherit from Shape. 
// Inheritance is also a way to express a "has-a" relationship between classes. 
// For example, a Car has an Engine, so Car can have a member variable that is an Engine.

using System;

class Shape
{
    public void setWidth(int w)
    {
        width = w;
    }

    public void setHeight(int h)
    {
        height = h;
    }

    protected int width;
    protected int height;
    // protected members can only be accessed by members of the class and its derived classes.
}

// Derived class
class Rectangle: Shape
{
    public int getArea()
    {
        return (width * height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle Rect = new Rectangle();
        Rect.setWidth(5);
        Rect.setHeight(7);
        // Print the area of the object.
        Console.WriteLine("Total area: {0}", Rect.getArea());
        Console.ReadKey();
    }
}