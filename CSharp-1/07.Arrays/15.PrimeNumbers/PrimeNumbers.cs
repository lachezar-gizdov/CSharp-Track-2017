using System;
using System.Linq;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool[] arr = new bool[n + 1];
        arr = Enumerable.Repeat(true, n + 1).ToArray();

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (arr[i] == true)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    arr[j] = false;
                }
            }
        }
        for (int i = n; i >= 2; i--)
        {
            if (arr[i] == true)
            {
                Console.WriteLine(i); break;
            }
        }

    }
}