using NUnit.Framework;

namespace Katas.RomanNumerals.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, "I", Description = "Simple 1 to I")]
        [TestCase(2, "II", Description = "Adding a second I")]
        [TestCase(3, "III", Description = "Adding a third I")]
        [TestCase(5, "V", Description = "Simple 5 to V")]
//        [TestCase(4, "IV", Description = "A one can be placed before a 5 to create a 4", Category = "Special Case")]
        public void Convert_Decimal_ToRomanNumber(int number, string expected)
        {
            Assert.That(Calculator.Convert(number), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(4, "IIII", Description = "Should not have characters 4 times in a row")]
        public void Convert_ExceptionCases_ShouldNotEqualResult(int number, string expected)
        {
            Assert.That(Calculator.Convert(number),  !Is.EqualTo(expected));
        }
    }
}