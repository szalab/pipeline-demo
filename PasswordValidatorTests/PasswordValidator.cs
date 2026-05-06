using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validator;

namespace Validator.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [TestMethod]
        public void ValidPassword_ReturnsTrue()
        {
            var result = _validator.IsValid("Test1234");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TooShortPassword_ReturnsFalse()
        {
            var result = _validator.IsValid("T1a");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoUpperCase_ReturnsFalse()
        {
            var result = _validator.IsValid("test1234");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoDigit_ReturnsFalse()
        {
            var result = _validator.IsValid("TestTest");
            Assert.IsFalse(result);
        }
    }
}