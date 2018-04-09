using Functional.Monad;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalTests
{
    [TestClass]
    public class ParseTests
    {
        [DataRow("26", "26")]
        [DataRow("NotAnAge", "Error")]
        [DataRow("180", "Error")]
        [DataTestMethod]
        public void WhenParsingAge_ThenGetResult(string input, string expected)
        {
            // Given

            // When
            var result = Parse.ParseAge(input);

            // Then
            Assert.AreEqual(expected, result.Match(() => "Error", age => age.Value.ToString()));
        }
    }
}