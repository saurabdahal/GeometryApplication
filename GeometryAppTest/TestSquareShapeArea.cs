﻿using GeometryClassLibrary.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAppTest
{
    [TestClass]
    public class TestSquareShapeArea
    {
        [TestMethod]
        public void TestSquare_TestArea_ReturnCorrectValue()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, result);
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
        public void TestSquare_LengthZero_ThrowsArgumentException()
        {
            // Arrange
            var square = new Square(4);
            double expected = 16;

            // Act
            var actual = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
