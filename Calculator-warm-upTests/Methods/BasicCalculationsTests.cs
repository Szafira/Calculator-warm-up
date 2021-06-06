using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicWebCalculator.Methods.Tests
{
    [TestFixture()]
    public class BasicCalculationsTests
    {
        private BasicCalculations _calc;

        [OneTimeSetUp]
        public void Init()
        {
            _calc = new BasicCalculations();
        }

        [TestCase(10)]
        [TestCase(100)]
        [Timeout(3)]
        public void squareAreaProperValue(int value)
        {
            _calc.squareArea(value);

        }
        [TestCase(-10)]
        [TestCase(-2)]
        public void squareAreaTooLowValue(int value)
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.squareArea(value));
            Assert.That(ex.Message == "Bok kwadratu musi być nieujemny");
        }

        [TestCase(0)]
        public void squareAreaEqualsZero(int value)
        {
            var ex = Assert.Throws<ArithmeticException>(() => _calc.squareArea(value));
            Assert.That(ex.Message == "Bok kwadratu nie może być zerowy");
        }

    }
}