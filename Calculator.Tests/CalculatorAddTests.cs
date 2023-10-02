using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorAddTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            double result = calculator.Add((double)2, (double)3);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
