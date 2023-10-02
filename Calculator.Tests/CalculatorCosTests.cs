using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorCosTests
    {
        [Test]
        public void Cos_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Cos(0); // cos(0) = 1

            // Assert
            Assert.That(result, Is.EqualTo(1).Within(0.001)); // Allowing for a small margin of error
        }
    }
}
