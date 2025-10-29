using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(15, calc.Add(10, 5));
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Subtract(10, 5));
        }
    }
}
