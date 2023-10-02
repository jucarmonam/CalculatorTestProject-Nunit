using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorAbsTests
    {
        [Test]
        public void Abs_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Abs(-5);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
