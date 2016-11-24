using System;
using System.Linq;

class Polynomials
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Sum of Polynomials");
        SumOfPolynomials(firstArr, secondArr);
        Console.WriteLine();
        Console.WriteLine("Subtraction of Polynomials");
        SubtractionOfPolynomials(firstArr, secondArr);
        Console.WriteLine();
        Console.WriteLine("Multiplication of Polynomials");
        MultiplicationtractionOfPolynomials(firstArr, secondArr);
    }

    static void SumOfPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            result[i] = firstArr[i] + secondArr[i];
        }

        foreach (int sum in result)
        {
            Console.Write("{0} ", sum);
        }
        Console.WriteLine();
    }

    static void SubtractionOfPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            result[i] = firstArr[i] - secondArr[i];
        }

        foreach (int sum in result)
        {
            Console.Write("{0} ", sum);
        }
        Console.WriteLine();
    }

    static void MultiplicationtractionOfPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            result[i] = firstArr[i] * secondArr[i];
        }

        foreach (int sum in result)
        {
            Console.Write("{0} ", sum);
        }
        Console.WriteLine();
    }
}