using System;

class ComparingFloats
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";

        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        if (Math.Abs(firstNum) > Math.Abs(secondNum))
        {
            if (Math.Abs(firstNum) - Math.Abs(secondNum) >= eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
        else
        {
            if (Math.Abs(secondNum) - Math.Abs(firstNum) >= eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
 
    }
}