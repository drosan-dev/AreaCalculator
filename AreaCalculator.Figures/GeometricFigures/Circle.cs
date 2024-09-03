namespace AreaCalculator.Figures.GeometricFigures
{
    public class Circle : GeometricFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("У круга радиус не может быть отрицательным.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Посчитать площадь круга
        /// </summary>
        protected sealed override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
