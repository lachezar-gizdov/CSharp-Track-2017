namespace Methods
{
    using System;

    public class MathOperations
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return area;
        }

        public static string NumberToDigit(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                default: throw new ArgumentException("Input is not a single digit!");
            }

            return result;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Invalid arguments.");
            }

            int maxElement = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (maxElement < elements[i])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static void PrintAsNumber(double number, NumberFormatTypes format)
        {
            switch (format)
            {
                case NumberFormatTypes.FixedPoint:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case NumberFormatTypes.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case NumberFormatTypes.RightAligned:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new InvalidOperationException("Invalid format!");
            }
        }

        public static double CalculateDistance(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            double distance = Math.Sqrt(((pointX2 - pointX1) * (pointX2 - pointX1)) + ((pointY2 - pointY1) * (pointY2 - pointY1)));

            return distance;
        }

        public static bool AreHorizontal(double pointY1, double pointY2)
        {
            return pointY1 == pointY2;
        }

        public static bool AreVertical(double pointX1, double pointX2)
        {
            return pointX1 == pointX2;
        }
    }
}