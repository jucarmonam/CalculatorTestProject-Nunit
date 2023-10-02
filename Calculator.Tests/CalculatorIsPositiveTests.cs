using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorIsPositiveTests
    {
        [Test]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.isPositive(42.0);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPositive_Zero_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.isPositive(0.0);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
