namespace CohesionAndCoupling.Utils
{
    using System;

    public static class Utils2D
    {
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }

        public static double CalculateDiagonal(double width, double height)
        {
            double diagonal = Math.Sqrt((width * width) + (height * height));

            return diagonal;
        }
    }
}
