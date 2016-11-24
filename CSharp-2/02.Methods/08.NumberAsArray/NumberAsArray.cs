using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string n = Console.ReadLine();
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] resultArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

        for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
        {
            if (firstArr[i] + secondArr[i] > 9)
            {
                resultArr[i] += (firstArr[i] + secondArr[i]) % 10;
                resultArr[i + 1] = 1;
            }
            else
            {
                resultArr[i] += firstArr[i] + secondArr[i];
            }
        }

        foreach (var item in resultArr)
        {
            Console.Write("{0} ", item);
        }
    }
}