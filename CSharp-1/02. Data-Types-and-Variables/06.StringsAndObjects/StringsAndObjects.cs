using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenatedObj = hello + " " + world;
        string concatenated = concatenatedObj.ToString();

        Console.WriteLine(concatenated);
    }
}