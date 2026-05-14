using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(6, 7);

            Assert.Equal(13, result);
        }
        [Fact]
        public void Subtract_ReturnCorrectDifference()
        {
            Calculator calc = new Calculator();
            int result = calc.Subtract(7, 6);
            Assert.Equal(1, result);
        }
    }
}