namespace AreaCalculator.Figures
{
    public abstract class GeometricFigure
    {
        private readonly Lazy<double> _area;

        protected GeometricFigure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => _area.Value;

        /// <summary>
        /// Посчитать площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double CalculateArea();
    }
}