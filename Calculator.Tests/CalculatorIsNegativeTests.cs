using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorIsNegativeTests
    {
        [Test]
        public void IsNegative_NegativeNumber_ReturnsTrue()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.isNegative(-42.0);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsNegative_Zero_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.isNegative(0.0);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
