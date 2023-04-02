using AreaCalc.Calculation;
using AreaCalc.Figures;
using Shouldly;

namespace AreaCalc.Tests
{
    public class TriangleAreaTests
    {
        private const double defaultTolerance = 0.001d;
        private const double lowTolerance = 0.00000000001d;
        private TriangleAreaStrategy areaStrategy;
        private DoubleToleranceComparer toleranceComparer;

        [SetUp]
        public void Setup()
        {
            areaStrategy = new TriangleAreaStrategy();
        }

        [Test]
        public void CalcArea_CommonTriangle_CorrectArea()
        {
            toleranceComparer = new DoubleToleranceComparer(defaultTolerance);
            var triangle = new Triangle(4, 6, 8);

            var area = areaStrategy.CalcArea(triangle);
            var correctArea = CalculateArea(triangle.SideA, triangle.SideB, triangle.SideC);

            area.ShouldBe(correctArea, toleranceComparer);
        }


        [Test]
        public void CalcArea_RightTriangle_CorrectArea()
        {
            toleranceComparer = new DoubleToleranceComparer(defaultTolerance);
            var triangle = new Triangle(5, 4, 3);

            var area = areaStrategy.CalcArea(triangle);
            var correctArea = CalculateArea(triangle.SideA, triangle.SideB, triangle.SideC);

            area.ShouldBe(correctArea, toleranceComparer);
        }


        [Test]
        public void CalcArea_CommonTriangleWithLowTolerance_CorrectArea()
        {
            toleranceComparer = new DoubleToleranceComparer(lowTolerance);
            var triangle = new Triangle(4, 6, 8);

            var area = areaStrategy.CalcArea(triangle);
            var correctArea = CalculateArea(triangle.SideA, triangle.SideB, triangle.SideC);

            area.ShouldBe(correctArea, toleranceComparer);
        }

        private double CalculateArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(
                p * (p - a) * (p - b) * (p - c)
            );
        }
    }
}
