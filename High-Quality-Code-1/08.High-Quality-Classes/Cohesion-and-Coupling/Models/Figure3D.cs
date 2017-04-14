namespace CohesionAndCoupling.Models
{
    using Contracts;

    public class Figure3D : IFigure3D
    {
        public Figure3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }

        public double Volume { get; set; }
    }
}
