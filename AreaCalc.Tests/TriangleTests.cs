using AreaCalc.Figures;
using Shouldly;

namespace AreaCalc.Tests
{
    public class TriangleTests
    {
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [Test]
        public void Triangle_SideZero_ShouldThrow(int a, int b, int c)
        {
            Triangle Action() => new(a, b, c);

            Should.Throw<ArgumentOutOfRangeException>((Func<Triangle>)Action);
        }

        
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [Test]
        public void Triangle_SideNegative_ShouldThrow(int a, int b, int c)
        {
            Triangle Action() => new(a, b, c);

            Should.Throw<ArgumentOutOfRangeException>((Func<Triangle>)Action);
        }

        
        [TestCase(10, 4, 4)]
        [TestCase(4, 10, 4)]
        [TestCase(4, 4, 10)]
        [Test]
        public void Triangle_ImpossibleTriangle_ShouldThrow(int a, int b, int c)
        {
            Triangle Action() => new(a, b, c);

            Should.Throw<ArgumentOutOfRangeException>((Func<Triangle>)Action);
        }
    }
}