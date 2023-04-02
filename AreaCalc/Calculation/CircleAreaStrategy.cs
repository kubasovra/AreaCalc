using System;
using AreaCalc.Figures;

namespace AreaCalc.Calculation
{
    public class CircleAreaStrategy : IAreaStrategy<Circle>
    {
        public double CalcArea(Circle figure)
            => Math.PI * Math.Pow(figure.Radius, 2);
    }
}
