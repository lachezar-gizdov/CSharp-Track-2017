using System;

class DivideBy7And5
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 35 == 0)
        {
            Console.WriteLine("true {0}", num);
        }
        else
        {
            Console.WriteLine("false {0}", num);
        }
    }
}