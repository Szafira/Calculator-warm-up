using NUnit.Framework;
using BasicWebCalculator.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicWebCalculator.Methods.Tests
{
    [TestFixture()]
    public class FormsTests
    {
        private Forms _forms;
        [OneTimeSetUp]
        public void Init()
        {
            _forms = new Forms();
        }

        [Test()]
        public void validationFormsSpecialCaseName()
        {
            var ex = Assert.Throws<Exception>(() => _forms.ValidateName("Ka$sie"));
            Assert.That(ex.Message == "Niepoprawne imie");
        }
        [Test()]
        public void validationFormsNonCapitalName()
        {
            var ex = Assert.Throws<Exception>(() => _forms.ValidateName("jan"));
            Assert.That(ex.Message == "Niepoprawne imie");
        }
        [Test()]
        public void validationFormsProperName()
        {
            _forms.ValidateName("Anna");

        }
    }
}