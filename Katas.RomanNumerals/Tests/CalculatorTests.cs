using NUnit.Framework;

namespace Katas.RomanNumerals.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(0, "", Description = "Roman numerals do not have a zero, return empty string")]
        [TestCase(1, "I", Description = "Simple 1 to I")]
        [TestCase(2, "II", Description = "Adding a second I")]
        [TestCase(3, "III", Description = "Adding a third I")]
        [TestCase(4, "IV", Description = "A 1 can be placed before a 5 to create a 4", Category = "Special Case")]
        [TestCase(5, "V", Description = "Simple 5 to V")]
        [TestCase(6, "VI", Description = "Adding two roman characters")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX", Description = "A 1 can be placed before a 10 to create a 9", Category = "Special Case")]
        [TestCase(10, "X", Description = "Simple 10 to X")]
        [TestCase(11, "XI")]
        [TestCase(14, "XIV")]

        public void Convert_Decimal_ToRomanNumber(int number, string expected)
        {
            Assert.That(Calculator.Convert(number), Is.EqualTo(expected));
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(70, "LXX")]
        [TestCase(80, "LXXX")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(300, "CCC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(700, "DCC")]
        [TestCase(800, "DCCC")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]

        public void Convert_SanityCheck(int number, string expected)
        {
            Convert_Decimal_ToRomanNumber(number, expected);
        }
    }
}