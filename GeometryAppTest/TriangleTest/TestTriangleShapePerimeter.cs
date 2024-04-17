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
        public void TestTriangle_ValidTriangle_CalculatePerimeter_ReturnsInCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(1, 4, 5); 

            // Act
            var area = triangle.CalculatePerimeter();

            // Assert
            Assert.AreNotEqual(6, Math.Round(area, 2)); 
        }

        public void TestTriangle_CalculatePerimeter_NegativeSides_ThrowsException()
        {
            // Arrange
            var triangle = new Triangle(2, -7, 5); 
            var area = triangle.CalculatePerimeter();
            // Assert
            Assert.ThrowsException<ArgumentException>(() => area);
        }

        public void TestTriangle_CalculatePerimeter_ZeroSides_ThrowsException()
        {
            // Arrange
            var triangle = new Triangle(0, 0, 0); 
            var area = triangle.CalculatePerimeter();
            Assert.ThrowsException<ArgumentException>(() => area);
        }
    }
}
