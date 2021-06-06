using NUnit.Framework;
using Basic_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_calculator.Tests
{
    [TestFixture()]
    public class functionsTests
    {

        private functions _fun;

        [OneTimeSetUp]
        public void Init()
        {
            _fun = new functions();
        }
        [Test()]
        [Timeout(10)]
        public void DivideTest()
        {
            var ex = Assert.Throws<ArgumentException>(() => _fun.Divide(3));
            Assert.That(ex.Message == "Parametr cannot be null");
        }

        [Test]
        public void DivisibilityNulled()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _fun.Divisibilty(0));
        }
        public void DivisibilityTwo()
        {
            var result = _fun.Divisibilty(2);
            Assert.That(result, Is.EqualTo("Divisble by 2"));
        }
        [Test]
        public void DivisibilityThree()
        {
            var result = _fun.Divisibilty(3);
            Assert.That(result, Is.EqualTo("Divisble by 3"));
        }
        [Test]
        public void DivisibilityFive()
        {
            var result = _fun.Divisibilty(5);
            Assert.That(result, Is.EqualTo("Divisble by 5"));
        }

        [Test]
        public void DivisibilitySeven()
        {
            var result = _fun.Divisibilty(7);
            Assert.That(result, Is.EqualTo("Divisble by 7"));
        }

    }
}
