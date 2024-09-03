using AreaCalculator.Figures;
using NUnit.Framework;
using System;

namespace AreaCalculator.Tests.Triangle
{
    [TestFixture]
    public class TriangleTests
    {
        /// <summary>
        /// Тест вычисления площади треугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            var triangle = new Figures.GeometricFigures.Triangle(3, 4, 5);

            var triangleSquare = triangle.Area;

            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тест отрицательных сторон треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Figures.GeometricFigures.Triangle(-10, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Figures.GeometricFigures.Triangle(0, -10, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Figures.GeometricFigures.Triangle(0, 0, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Figures.GeometricFigures.Triangle(-10, -10, -10));
        }
    }
}
