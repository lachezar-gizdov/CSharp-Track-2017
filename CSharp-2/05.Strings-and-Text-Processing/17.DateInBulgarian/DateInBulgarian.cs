using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter Date and Time in the format day.month.year hour:minute:second : ");
        CultureInfo bg = new CultureInfo("bg-BG");
        // 6.12.2016 12:30:30

        DateTime input = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy h:mm:ss", bg);

        input = input.AddMinutes(30).AddHours(6);

        Console.WriteLine();
        Console.WriteLine("Date with added 6 hours and 30 minutes: {0}", input);
        Console.WriteLine("Day of week in Bulgarian: {0}", bg.DateTimeFormat.DayNames[(int)input.DayOfWeek]);

    }
}