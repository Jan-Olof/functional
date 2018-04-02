using Functional;
using Functional.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static LaYumba.Functional.F;

namespace FunctionalTests
{
    [TestClass]
    public class RisksTests
    {
        [DataRow(-1)]
        [DataRow(120)]
        [DataRow(10500)]
        [DataTestMethod]
        public void WhenCalculatingRisk_ThenMappingToNone(int age)
        {
            // Given
            var subject = new Subject { Age = Age.Of(age) };

            // When
            var result = CalculateRisk.RiskOf(subject);

            // Then
            Assert.AreEqual(None, result);
        }

        [DataRow(10, Risk.Low)]
        [DataRow(119, Risk.Medium)]
        [DataRow(0, Risk.Low)]
        [DataRow(60, Risk.Medium)]
        [DataRow(59, Risk.Low)]
        [DataTestMethod]
        public void WhenCalculatingRisk_ThenMappingToSome(int age, Risk expected)
        {
            // Given
            var subject = new Subject { Age = Age.Of(age) };

            // When
            var result = CalculateRisk.RiskOf(subject);

            // Then
            Assert.AreEqual(Some(expected), result);
        }
    }
}