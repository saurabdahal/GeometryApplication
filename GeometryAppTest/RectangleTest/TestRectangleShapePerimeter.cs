using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest.RectangleTest
{
    [TestClass]
    public class TestRectangleShapePerimeter
    {
        [TestMethod]
        public void TestRectangle_TestPerimeter_ReturnCorrectValue()
        {
            // Arrange
            var rectangle = new Rectangle(5,10);

            // Act
            var result = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void CalculatePerimeter_ThrowsExceptionOnNegativePerimeter()
        {
            // Arrange
            int height = 5;
            int width = -5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(height, width).CalculatePerimeter());
        }

        [TestMethod]
        public void TestRectangle_Constructor_LengthZero_ThrowsArgumentException()
        {
            int height = 0;
            int width = 5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(height, width).CalculatePerimeter());
        }
    }
}
