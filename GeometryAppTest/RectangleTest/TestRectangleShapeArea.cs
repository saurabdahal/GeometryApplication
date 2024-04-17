using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest.RectangleTest
{
    [TestClass]
    public class TestRectangleShapeArea
    {
        [TestMethod]
        public void CalculateArea_WithValidDimensions_ReturnsCorrectArea()
        {
            // Arrange
            double height = 5;
            double width = 10;
            Rectangle rectangle = new Rectangle(height, width);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(50, area);
        }

        [TestMethod]
        public void CalculateArea_WithZeroDimensions_ReturnsZeroArea()
        {
            // Arrange
            double height = 0;
            double width = 10;
            Rectangle rectangle = new Rectangle(height, width);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CalculateArea_WithNegativeDimensions_ReturnsNegativeArea()
        {
            // Arrange
            double height = -5;
            double width = 10;
            var rectangle = new Rectangle(height, width);

            //Act 
            var area = rectangle.CalculateArea();
            // Act & Assert
            Assert.IsTrue(area < 0, "invalid rectangle, area is always a positive value");
        }
    }
}
