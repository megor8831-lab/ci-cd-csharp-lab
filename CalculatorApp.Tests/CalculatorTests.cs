using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            var calc = new Calculator();

            int result = calc.Add(2, 3);

            Assert.Equal(5, result);
        }
    }
}