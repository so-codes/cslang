// Static Members of a C# Class
// Static members are shared by all instances of a class.  They are
// declared with the static keyword.  Static members are accessed
// through the class name, not through an instance of the class.
// Static members are often used to implement utility functions
// that are not specific to any one instance of a class.
// Static members are also used to implement constants.
// Static members are declared in the same way as instance members,
// except that they are declared with the static keyword.
// Static members are initialized when the class is loaded into
// memory.  They are initialized before any instances of the class
// are created.

using System;
class StaticVar
{
    public static int num;
    public void count()
    {
        num++;
    }

    public static int getNum()
    {
        return num;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StaticVar s = new StaticVar();
        s.count();
        s.count();
        s.count();
        Console.WriteLine("Variable num: {0}", StaticVar.getNum());
        Console.ReadKey();
    }
}
