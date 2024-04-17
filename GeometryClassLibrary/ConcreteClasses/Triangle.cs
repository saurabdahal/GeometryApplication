using GeometryClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary.ConcreteClasses
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            var s = (_sideA + _sideB + _sideC) / 2; 
            var area = Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
            return area;
        }

        public double CalculatePerimeter()
        {
            return _sideA + _sideB + _sideC;
        }
    }
}
