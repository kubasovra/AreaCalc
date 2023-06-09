﻿using System;
using System.Collections.Generic;
using AreaCalc.Figures;

namespace AreaCalc.Calculation
{
    public class TriangleAreaStrategy : IAreaStrategy<Triangle>
    {
        private readonly DoubleToleranceComparer _toleranceComparer;

        public TriangleAreaStrategy(DoubleToleranceComparer toleranceComparer)
        {
            _toleranceComparer = toleranceComparer;
        }

        public double CalcArea(Triangle figure)
        {
            if (figure.IsRight(_toleranceComparer))
            {
                var sides = new List<double> { figure.SideA, figure.SideB, figure.SideC };
                sides.Sort();
                return sides[0] * sides[1] / 2;
            }
            var p = (figure.SideA + figure.SideB + figure.SideC) / 2;
            var area = Math.Sqrt(p * (p - figure.SideA) * (p - figure.SideB) * (p - figure.SideC));
            return area;
        }
    }
}
