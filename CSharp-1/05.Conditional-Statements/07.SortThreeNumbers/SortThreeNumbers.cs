using System;

class SortThreeNumbers
{
    static void Main()
    {
        double a = 5; //double.Parse(Console.ReadLine());
        double b = 4; //double.Parse(Console.ReadLine());
        double c = 6; //double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b ,c);
            }
            else if (a >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
    }
}