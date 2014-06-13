using NUnit.Framework;

namespace Katas.RomanNumerals.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Convert_1_I()
        {
            Assert.That(Calculator.Convert(1), Is.EqualTo("I"));
        } 
    }
}