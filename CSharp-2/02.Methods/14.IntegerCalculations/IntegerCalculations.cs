using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    static void Main()
    {
        int count = 5;
        //int count = int.Parse(Console.ReadLine()); //All calculations for any number of integers
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        MinimalNum(inputNumbers, count);
        Maximum(inputNumbers, count);
        Average(inputNumbers, count);
        Sum(inputNumbers, count);
        Product(inputNumbers, count);
    }
    static void Sum(int[] inputNumbers, int count)
    {
        BigInteger sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += inputNumbers[i];
        }

        Console.WriteLine(sum);
    }

    static void Product(int[] inputNumbers, int count)
    {
        BigInteger product = 1;

        for (int i = 0; i < count; i++)
        {
            product *= inputNumbers[i];
        }

        Console.WriteLine("{0}", product);
    }

    static void Average(int[] inputNumbers, int count)
    {
        double average = 0;
        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += (double)inputNumbers[i];
        }

        average = sum / count;
        Console.WriteLine("{0:F2}", average);
    }

    static void Maximum(int[] inputNumbers, int count)
    {
        BigInteger maximum = inputNumbers[0];

        for (int i = 1; i < count; i++)
        {
            if (maximum < inputNumbers[i])
            {
                maximum = inputNumbers[i];
            }
        }

        Console.WriteLine(maximum);
    }

    static void MinimalNum(int[] inputNumbers, int count)
    {
        BigInteger minimal = inputNumbers[0];

        for (int i = 1; i < count; i++)
        {
            if (minimal > inputNumbers[i])
            {
                minimal = inputNumbers[i];
            }
        }

        Console.WriteLine(minimal);
    }
}