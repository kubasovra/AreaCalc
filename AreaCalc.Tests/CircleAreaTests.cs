using AreaCalc.Calculation;
using AreaCalc.Figures;
using Shouldly;

namespace AreaCalc.Tests
{
    public class CircleAreaTests
    {
        private const double defaultTolerance = 0.001d;
        private const double lowTolerance = 0.00000000001d;
        private CircleAreaStrategy areaStrategy;
        private DoubleToleranceComparer toleranceComparer;

        [SetUp]
        public void Setup()
        {
            areaStrategy = new CircleAreaStrategy();
        }

        [Test]
        public void CalcArea_Circle_CorrectArea()
        {
            toleranceComparer = new DoubleToleranceComparer(defaultTolerance);
            var circle = new Circle(5);

            var area = areaStrategy.CalcArea(circle);
            var correctArea = CalculateArea(circle.Radius);

            area.ShouldBe(correctArea, toleranceComparer);
        }


        [Test]
        public void CalcArea_CircleWithLowTolerance_CorrectArea()
        {
            toleranceComparer = new DoubleToleranceComparer(lowTolerance);
            var circle = new Circle(5);

            var area = areaStrategy.CalcArea(circle);
            var correctArea = CalculateArea(circle.Radius);

            area.ShouldBe(correctArea, toleranceComparer);
        }

        private double CalculateArea(double radius)
            => Math.PI * Math.Pow(radius, 2);
    }
}
