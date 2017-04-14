namespace CohesionAndCoupling.Utils
{
    using System;

    public class Utils3D
    {
        public static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            return distance;
        }

        public static double CalculateDiagonal(double width, double height, double depth)
        {
            double diagonal = Math.Sqrt((width * width) + (height * height) + (depth * depth));

            return diagonal;
        }

        public static decimal CalculateVolume(double width, double height, double depth)
        {
            decimal volume = (decimal)width * (decimal)height * (decimal)depth;

            return volume;
        }
    }
}
