using System;

class OddOrEven
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("even {0}", num);
        }
        else
        {
            Console.WriteLine("odd {0}", num);
        }
    }
}