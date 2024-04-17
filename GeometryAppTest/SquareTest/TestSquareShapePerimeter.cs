using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest
{
    [TestClass]
    public class TestSquareShapePerimeter
    {
        [TestMethod]
        public void CalculatePerimeter_WithValidSize_ReturnsCorrectPerimeter()
        {
            // Arrange
            int size = 5;
            Square square = new Square(size);

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter);
        }

        [TestMethod]
        public void CalculatePerimeter_WithZeroSize_ReturnsZeroPerimeter()
        {
            // Arrange
            int size = 0;
            Square square = new Square(size);

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(0, perimeter, "invalid square; perimeter of a square cannot be zero");
        }

        [TestMethod]
        public void CalculatePerimeter_WithNegativeSize_ReturnsNegativePerimeter()
        {
            // Arrange
            int size = -4;
            Square square = new Square(size);

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.IsTrue(perimeter<0, "invalid square; perimeter of a square cannot be a negative value");
        }
    }
}
