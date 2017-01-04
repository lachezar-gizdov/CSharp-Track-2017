namespace Points
{
    using System;

    static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2) + Math.Pow(second.Z - first.Z, 2));

            return distance;
        }
    }
}