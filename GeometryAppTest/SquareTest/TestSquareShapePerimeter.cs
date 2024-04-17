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
        public void TestSquare_TestPerimeter_ReturnCorrectValue()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSquare_Constructor_ThrowsExceptionOnNegativeSize()
        {
            // Arrange
            int testSize = -5;

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Square(testSize));
        }

        [TestMethod]
        public void TestSquare_Constructor_LengthZero_ThrowsArgumentException()
        {
            var testValue = new Square(0);
            // Assert
            Assert.ThrowsException<ArgumentException>(() => testValue);
        }
    }
}
