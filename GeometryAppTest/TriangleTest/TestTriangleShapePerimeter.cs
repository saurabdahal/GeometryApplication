using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest.TriangleTest
{
    [TestClass]
    public class TestTriangleShapePerimeter
    {
        [TestMethod]
        public void CalculatePerimeter_WithValidSides_ReturnsInCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(1, 4, 5); 

            // Act
            var area = triangle.CalculatePerimeter();

            // Assert
            Assert.AreNotEqual(6, Math.Round(area, 2)); 
        }

        [TestMethod]
        public void CalculatePerimeter_WithNegativeSides_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle(2, -7, 5); 

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }

        [TestMethod]
        public void CalculatePerimeter_WithZeroSides_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle(0, 0, 0);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }
    }
}
