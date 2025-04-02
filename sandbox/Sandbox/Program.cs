using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetName("Jerry");
        p1.SetAge(23);
        
        p1.Display();

        string theName = p1.GetName();
        Console.WriteLine($"The name is {theName}");
    }

}