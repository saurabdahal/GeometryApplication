using GeometryClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary.ConcreteClasses
{
    public class Square : IShape
    {
        private readonly int _size;

        public Square(int size)
        {
            if (size < 0) throw new ArgumentOutOfRangeException("size should be a positive integer");
            if(size==0) throw new ArgumentException("The size parameter cannot be zero.");
            _size = size;
        }

        public double CalculateArea()
        {
            return _size * _size;
        }

        public double CalculatePerimeter()
        {
            return 4 * _size;
        }
    }
}
