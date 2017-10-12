using Functional.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalTests
{
    [TestClass]
    public class BicExistsValidatorTests
    {
        [DataRow("ABCDEFGJI123", true)]
        [DataRow("XXXXXXXXXX", false)]
        [DataTestMethod]
        public void WhenBicNotFound_ThenValidationFails(string bic, bool expected)
        {
            // Given
            var sut = new BicExistsValidator(() => new[] { "ABCDEFGJI123" });

            // When
            var result = sut.IsValid(new MakeTransfer { Bic = bic });

            // Then
            Assert.AreEqual(expected, result);
        }
    }
}