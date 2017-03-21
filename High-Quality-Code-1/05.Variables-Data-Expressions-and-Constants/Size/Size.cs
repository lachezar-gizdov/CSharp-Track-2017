namespace SizeHomework
{
    using System;

    public class Size
    {
        private double width;

        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotated)
        {
            var figureAngleCosAbs = Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotated));
            var figureAngleSinAbs = Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotated));

            var currentFigureSize = (figureAngleCosAbs * size.width) + (figureAngleSinAbs * size.height);
            var newFigureSize = (figureAngleSinAbs * size.width) + (figureAngleCosAbs * size.height);

            var result = new Size(currentFigureSize, newFigureSize);

            return result;
        }
    }
}
