﻿using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(-(i+1));
            i++;
        }
    }
}