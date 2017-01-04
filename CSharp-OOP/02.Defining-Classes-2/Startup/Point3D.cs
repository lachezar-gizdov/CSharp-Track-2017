namespace Points
{
    using System.Text;

    public struct Point3D
    {
        //fields
        private static readonly Point3D Start;

        //constructors
        static Point3D()
        {
            Start = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Point Coordinates: X = ").Append(this.X + ", ").Append("Y = ").Append(this.Y + ", ").Append("Z = ").Append(this.Z);

            return result.ToString();
        }
    }
}
