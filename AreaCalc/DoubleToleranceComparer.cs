using System;
using System.Collections.Generic;

namespace AreaCalc
{
    public class DoubleToleranceComparer : IEqualityComparer<double>
    {
        private readonly double _tolerance;

        public DoubleToleranceComparer(double tolerance)
        {
            _tolerance = tolerance;
        }

        public bool Equals(double x, double y)
            => Math.Abs(x - y) <= _tolerance;

        public int GetHashCode(double obj) 
            => obj.GetHashCode();
    }
}
