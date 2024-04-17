using GeometryClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary.ConcreteClasses
{
    public class Rectangle : IShape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double CalculateArea()
        {
            return _width * _height;
        }

        public double CalculatePerimeter()
        {
            if (_width < 0 || _height < 0) throw new ArgumentException("dimensions cannot be negative");
            if (_width == 0 || _height == 0) throw new ArgumentException("dimensions cannot be zero");

            return 2 * (_width + _height);
        }
    }
}
