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

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double CalculateArea()
        {
            return _width * _height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}
