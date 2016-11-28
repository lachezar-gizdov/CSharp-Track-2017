using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        IsLeap(year);
    }

    static void IsLeap(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}