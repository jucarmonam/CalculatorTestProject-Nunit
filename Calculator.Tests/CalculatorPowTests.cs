using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorPowTests
    {
        [Test]
        public void Pow_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Pow(2, 3.0);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
    }
}
