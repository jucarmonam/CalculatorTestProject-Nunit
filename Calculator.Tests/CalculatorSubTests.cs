using CSharpCalculator;
using NUnit.Framework.Internal;

namespace App.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CalculatorSubTests
    {
        [Test]
        public void Substract_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new ();

            // Act
            double result = calculator.Sub((double)4, (double)2);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
