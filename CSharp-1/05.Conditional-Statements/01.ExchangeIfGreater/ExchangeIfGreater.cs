﻿using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("{0} {1}", a , b);
    }
}