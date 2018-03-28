using Functional;
using LaYumba.Functional;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LaYumba.Functional.F;

namespace FunctionalTests
{
    [TestClass]
    public class GreetingTests
    {
        [TestMethod]
        public void WhenGreeting_ThenGreetJohn()
        {
            // Given
            var sut = new Greeting();
            Option<string> john = Some("John");

            // When
            var result = john.Map(sut.Greet);

            // Then
            Assert.AreEqual(Some("hello, John"), result);
        }

        [TestMethod]
        public void WhenGreeting_ThenGreetNone()
        {
            // Given
            var sut = new Greeting();
            Option<string> nobody = None;

            // When
            var result = nobody.Map(sut.Greet);

            // Then
            Assert.AreEqual(None, result);
        }
    }
}