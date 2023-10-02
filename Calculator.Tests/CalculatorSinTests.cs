using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorSinTests
    {
        [Test]
        public void Sin_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Sin(Math.PI / 2); // sin(π/2) = 1

            // Assert
            Assert.That(result, Is.EqualTo(1).Within(0.001)); // Allowing for a small margin of error
        }
    }
}
