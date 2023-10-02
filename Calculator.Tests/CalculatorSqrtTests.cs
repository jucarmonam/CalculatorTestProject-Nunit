using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorSqrtTests
    {
        [Test]
        public void Sqrt_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Sqrt(16);

            // Assert
            Assert.That(result, Is.EqualTo(4.0));
        }
    }
}
