using System;

class PrimeCheck
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        if (num > 2)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}