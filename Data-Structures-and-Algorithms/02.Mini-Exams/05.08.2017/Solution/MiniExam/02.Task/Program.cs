using System;

namespace MiniExam
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double point1x = double.Parse(input[0]);
            double point1y = double.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            double point2x = double.Parse(input[0]);
            double point2y = double.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            double point3x = double.Parse(input[0]);
            double point3y = double.Parse(input[1]);

            double first = point2x - point1x;
            double second = point2y - point1y;
            double side1 = Math.Sqrt((first * first) + (second * second));

            first = point3x - point1x;
            second = point3y - point1y;
            double side2 = Math.Sqrt((first * first) + (second * second));

            first = point3x - point2x;
            second = point3y - point2y;
            double side3 = Math.Sqrt((first * first) + (second * second));

            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            double height1 = area * 2 / side1;
            double height2 = area * 2 / side2;
            double height3 = area * 2 / side3;

            Console.WriteLine("{0:f2}", height3);
            Console.WriteLine("{0:f2}", height2);
            Console.WriteLine("{0:f2}", height1);
        }
    }
}