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
            if (_sideA < 0 || _sideB < 0 || _sideC < 0) throw new ArgumentException("all sides should be greater than zero");
            if (_sideA == 0 || _sideB == 0 || _sideC == 0) throw new ArgumentException("sides must not be equal to zero");


            var s = (_sideA + _sideB + _sideC) / 2; 
            var area = Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
            return area;
        }

        public double CalculatePerimeter()
        {
            if (_sideA < 0 || _sideB < 0 || _sideC < 0) throw new ArgumentException("all sides should be greater than zero");
            if (_sideA == 0 || _sideB == 0 || _sideC == 0) throw new ArgumentException("sides must not be equal to zero");

            return _sideA + _sideB + _sideC;
        }
    }
}
