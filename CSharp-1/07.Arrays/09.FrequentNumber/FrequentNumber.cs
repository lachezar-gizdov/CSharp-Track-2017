using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int frequentNumber = 0;
        int currentCount = 1;
        int maxCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (!(i == j))
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                }
                else
                {
                    continue;
                }
            }
            if (currentCount > maxCount)
            {
                frequentNumber = numbers[i];
            }
            maxCount = Math.Max(maxCount, currentCount);
            currentCount = 1;
        }

        Console.WriteLine("{1} ({0} times)",maxCount, frequentNumber);
    }
}