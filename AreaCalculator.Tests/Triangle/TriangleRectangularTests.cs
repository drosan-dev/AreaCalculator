using NUnit.Framework;

namespace AreaCalculator.Tests.Triangle
{
    [TestFixture]
    internal class TriangleRectangularTests
    {
        /// <summary>
        /// Тест прямоульного треугольника
        /// </summary>
        [Test]
        public void IsRectangularTest()
        {
            var triangle = new Figures.GeometricFigures.Triangle(3, 4, 5);

            var isTriangleRightAngled = triangle.IsRectangular;

            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тест не прямоугольного треугольника
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            var triangle = new Figures.GeometricFigures.Triangle(6, 2, 5);

            var isTriangleRightAngled = triangle.IsRectangular;

            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
