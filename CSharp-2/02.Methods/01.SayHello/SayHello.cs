using System;

class SayHello
{
    static void Main()
    {
        string name = Console.ReadLine();

        PrintHello(name);
    }

    static void PrintHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}