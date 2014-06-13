using NUnit.Framework;

namespace Katas.RomanNumerals.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, "I", Description = "Simple 1 to I")]
        [TestCase(2, "II", Description = "Adding a second I")]
        [TestCase(3, "III", Description = "Adding a third I")]
        public void Convert_Decimal_ToRomanNumber(int number, string expected)
        {
            Assert.That(Calculator.Convert(number), Is.EqualTo(expected));
        } 
    }
}