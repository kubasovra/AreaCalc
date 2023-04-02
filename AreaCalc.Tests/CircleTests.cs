using AreaCalc.Figures;
using Shouldly;

namespace AreaCalc.Tests
{
    public class CircleTests
    {
        [Test]
        public void Circle_RadiusZero_ShouldThrow()
        {
            Circle Action() => new(0);

            Should.Throw<ArgumentOutOfRangeException>((Func<Circle>)Action);
        }

        [Test]
        public void Circle_RadiusNegative_ShouldThrow()
        {
            Circle Action() => new(-1);

            Should.Throw<ArgumentOutOfRangeException>((Func<Circle>)Action);
        }
    }
}
