using AreaCalculator.Figures.GeometricFigures;
using NUnit.Framework;
using System;

namespace SquareCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// Тест вычисления площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            var circle = new Circle(10);

            Assert.AreEqual(314.15926535897933, circle.Area);
        }

        /// <summary>
        /// Тест отрицательного радиуса круга
        /// </summary>
        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
                new Circle(-1));
        }
    }
}