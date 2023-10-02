using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorDivideTests
    {
        [Test]
        public void Divide_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Divide(10.0, 2.0);

            // Assert
            Assert.That(result, Is.EqualTo(5.0));
        }
    }
}
