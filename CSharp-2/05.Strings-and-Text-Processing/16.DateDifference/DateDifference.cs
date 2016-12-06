using System;
using System.Linq;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter Date in the format day.month.year: ");

        Console.Write("First Date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);

        Console.Write("Second Date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);

        Distance(firstDate, secondDate);
    }

    static void Distance(DateTime firstDate, DateTime secondDate)
    {
        double distance = (firstDate - secondDate).TotalDays;

        Console.WriteLine("Distance: {0} days", Math.Abs(distance));
    }
}