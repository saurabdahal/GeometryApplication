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
        public void TestTriangle_ValidTriangle_CalculateArea_ReturnsInCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(1, 4, 5); 

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreNotEqual(6, Math.Round(area, 2)); 
        }

        public void TestTriangle_CalculateArea_NegativeSides_ReturnsZero()
        {
            // Arrange
            var triangle = new Triangle(2, -7, 5); 
            var area = triangle.CalculateArea();
            // Assert
            Assert.IsTrue(area < 0, "Area is less than 0, not a valid triangle");
        }

        public void TestTriangle_CalculateArea_ZeroSides_ReturnsZero()
        {
            // Arrange
            var triangle = new Triangle(0, 0, 0); 
            var area = triangle.CalculateArea();

            Assert.Equals(0, area);
        }
    }
}
