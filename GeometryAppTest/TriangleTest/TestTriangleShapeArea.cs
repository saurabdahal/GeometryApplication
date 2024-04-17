using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest.TriangleTest
{
    [TestClass]
    public class TestTriangleShapeArea
    {
        [TestMethod]
        public void CalculateArea_WithValidSides_ReturnsInCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(1, 4, 5); 

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreNotEqual(6, Math.Round(area, 2)); 
        }

        [TestMethod]
        public void CalculateArea_WithNegativeSides_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle(2, -7, 5); 

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_WithZeroSides_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle(0, 2, 4);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }
    }
}
