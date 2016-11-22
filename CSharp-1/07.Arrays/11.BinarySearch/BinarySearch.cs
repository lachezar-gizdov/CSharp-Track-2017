using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int midEl = 0;
        bool found = false;
        int left = 0;
        int right = n - 1;

        for (int i = 0; i < n; i++)
        {
           numbers[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        while (left <= right && found != true)
        {
            midEl = (left + right) / 2;
            if (x == numbers[midEl])
            {
                found = true;
            }
            else if (x > numbers[midEl])
            {
                left = midEl + 1;
            }
            else if (x < numbers[midEl])
            {
                right = midEl - 1;
            }
        }

        if (!found)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(midEl);
        }

    }
}