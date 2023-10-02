using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorMultiplyTests
    {

        [Test]
        public void Multiply_TwoDoubles_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Multiply(2.5, 3.0);

            // Assert
            Assert.AreEqual(7.5, result);
        }
    }
}