using Functional.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionalTests
{
    [TestClass]
    public class DateNotPastValidatorTests
    {
        private readonly DateTime _presentDate = new DateTime(2017, 10, 15);

        [DataRow(+1, true)]
        [DataRow(0, true)]
        [DataRow(-1, false)]
        [DataTestMethod]
        public void WhenTransferDateIsPast_ThenValidatorFails(int offset, bool expected)
        {
            // Given
            var sut = new DateNotPastValidator(_presentDate);
            var cmd = new MakeTransfer { Date = _presentDate.AddDays(offset) };

            // When
            var result = sut.IsValid(cmd);

            // Then
            Assert.AreEqual(expected, result);
        }
    }
}