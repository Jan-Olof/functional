using Functional;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalTests
{
    [TestClass]
    public class AgeTests
    {
        [DataRow(10, "Age is 10")]
        [DataRow(119, "Age is 119")]
        [DataRow(-1, "Age is invalid")]
        [DataRow(120, "Age is invalid")]
        [DataRow(10500, "Age is invalid")]
        [DataTestMethod]
        public void WhenMatchingAge_ThenCheckValue(int age, string expected)
        {
            // Given
            var optionAge = Age.Of(age);

            // When
            string result = optionAge.Match(() => "Age is invalid", n => $"Age is {n.Value}");

            // Then
            Assert.AreEqual(expected, result);
        }

        [DataRow(10, true)]
        [DataRow(119, true)]
        [DataRow(-1, false)]
        [DataRow(120, false)]
        [DataRow(10500, false)]
        [DataTestMethod]
        public void WhenMatchingAge_ThenIsAgeValid(int age, bool expected)
        {
            // Given
            var optionAge = Age.Of(age);

            // When
            bool result = optionAge.Match(() => false, n => true);

            // Then
            Assert.AreEqual(expected, result);
        }
    }
}