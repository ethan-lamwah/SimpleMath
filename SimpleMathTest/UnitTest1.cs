using Xunit;

namespace SimpleMathTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var math = new SimpleMath.MathFunctions();
            Assert.Equal(10, math.Add(5, 5));
        }

        [Fact]
        public void TestSubtract()
        {
            var math = new SimpleMath.MathFunctions();
            Assert.Equal(0, math.Subtract(5, 5));
        }

        [Fact]
        public void TestDivide()
        {
            var math = new SimpleMath.MathFunctions();
            Assert.Equal(1, math.Divide(5, 5));
        }

        [Fact]
        public void TestMultiply()
        {
            var math = new SimpleMath.MathFunctions();
            Assert.Equal(25, math.Multiply(5, 5));
        }

        [Fact]
        public void TestModular()
        {
            var math = new SimpleMath.MathFunctions();
            Assert.Equal(0, math.Modular(5, 5));
        }

    }
}