using System;
using System.Collections.Generic;

namespace AreaCalc.Figures
{
    public class Triangle : IFigure
    {
        private const string SideLengthErrorMessage = "Side length must be greater than 0";
        private const string ImpossibleTriangleError = "One side must be less than the sum of others";

        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentOutOfRangeException(nameof(sideA), SideLengthErrorMessage);
            if (sideB <= 0)
                throw new ArgumentOutOfRangeException(nameof(sideB), SideLengthErrorMessage);
            if (sideC <= 0)
                throw new ArgumentOutOfRangeException(nameof(sideC), SideLengthErrorMessage);

            if (sideA >= sideB + sideC)
                throw new ArgumentOutOfRangeException(nameof(sideA), ImpossibleTriangleError);
            if (sideB >= sideA + sideC)
                throw new ArgumentOutOfRangeException(nameof(sideA), ImpossibleTriangleError);
            if (sideC >= sideB + sideA)
                throw new ArgumentOutOfRangeException(nameof(sideA), ImpossibleTriangleError);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        
        public bool IsRight(IEqualityComparer<double> comparer)
        {
            var sides = new List<double> { SideA, SideB, SideC };
            sides.Sort();
            var longestSquare = Math.Pow(sides[2], 2);
            var restSquaresSum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
            return comparer.Equals(longestSquare, restSquaresSum);
        }
    }
}
