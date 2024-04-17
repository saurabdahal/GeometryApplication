using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest.SquareTest
{
    [TestClass]
    public class TestSquareShapeArea
    {
        [TestMethod]
        public void CalculateArea_WithValidSize_ReturnsCorrectArea()
        {
            // Arrange
            int size = 5;
            Square square = new Square(size);

            // Act
            double area = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, area);
        }

        [TestMethod]
        public void CalculateArea_WithZeroSize_ThrowsArgumentException()
        {
            // Arrange
            int size = 0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Square(size).CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_WithNegativeSize_ThrowsArgumentException()
        {
            // Arrange
            int size = -5;


            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Square(size).CalculateArea());
        }
    }
}
