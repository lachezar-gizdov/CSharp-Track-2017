namespace Methods
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var maxElementInArray = MathOperations.FindMax(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(maxElementInArray);

            var triangleArea = MathOperations.CalculateTriangleArea(3, 4, 5);
            Console.WriteLine(triangleArea);

            var numberInDigits = MathOperations.NumberToDigit(5);
            Console.WriteLine(numberInDigits);

            double pointX1 = 3;
            double pointY1 = -1;
            double pointX2 = 3;
            double pointY2 = 2.5;

            var distance = MathOperations.CalculateDistance(pointX1, pointY1, pointX2, pointY2);
            Console.WriteLine(distance);

            var horizontal = MathOperations.AreHorizontal(pointY1, pointY2);
            Console.WriteLine("Horizontal? -> {0}", horizontal);

            var vertical = MathOperations.AreVertical(pointX1, pointX2);
            Console.WriteLine("Vertical? -> {0}", vertical);

            MathOperations.PrintAsNumber(1.3, NumberFormatTypes.FixedPoint);
            MathOperations.PrintAsNumber(0.75, NumberFormatTypes.Percent);
            MathOperations.PrintAsNumber(2.30, NumberFormatTypes.RightAligned);

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));
            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1993, 3, 11), "gamer, high results");

            Console.WriteLine("Is {0} older than {1} ? -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
