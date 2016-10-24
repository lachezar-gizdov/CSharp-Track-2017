using System;

class FourDigits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int firstDigit = input / 1000;
        int secondDigit = (input / 100) % 10;
        int thirdDigit = (input / 10) % 10;
        int fourthDigit = input % 10;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

        Console.WriteLine(sum);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}