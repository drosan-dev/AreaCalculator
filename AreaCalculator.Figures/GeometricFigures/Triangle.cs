namespace AreaCalculator.Figures.GeometricFigures
{
    public class Triangle : GeometricFigure
    {

        private readonly Lazy<bool> _isRectangular;

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; }

        private double MaxSide { 
            get => new[] { FirstSide, SecondSide, ThirdSide }.Max(); 
        }

        /// <summary>
        /// Прямоульльный ли треугольник
        /// </summary>
        public bool IsRectangular => _isRectangular.Value;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRectangular = new Lazy<bool>(CheckIsRectangular);
        }

        /// <summary>
        /// Проверить прямоугольный ли треугольник
        /// </summary>
        private bool CheckIsRectangular()
        {
            return Math.Pow(MaxSide, 2) + Math.Pow(MaxSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
        }

        /// <summary>
        /// Посчитать площадь треугольника
        /// </summary>
        protected sealed override double CalculateArea()
        {
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideCoefficient = halfPerimeter - FirstSide;
            var secondSideCoefficient = halfPerimeter - SecondSide;
            var thirdSideCoefficient = halfPerimeter - ThirdSide;

            return Math.Sqrt(halfPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
        }
    }
}
