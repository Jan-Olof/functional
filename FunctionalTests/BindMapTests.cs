using Functional.Map;
using Functional.Monad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalTests
{
    [TestClass]
    public class BindMapTests
    {
        private readonly List<Neighbor> _neighbors = new List<Neighbor>
        {
            new Neighbor("John", new List<string> { "Fluffy", "Thor" }),
            new Neighbor("Tim", new List<string>()),
            new Neighbor("Carl", new List<string> { "Sybil" }),
        };

        [TestMethod]
        public void TestShouldBindNeighborsPets()
        {
            // Given

            // When
            var result = _neighbors.Bind(neighbor => neighbor.Pets).ToList();

            // Then
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("Fluffy"));
            Assert.IsTrue(result.Contains("Thor"));
            Assert.IsTrue(result.Contains("Sybil"));
        }

        [TestMethod]
        public void TestShouldMapNeighborsPets()
        {
            // Given

            // When
            var result = _neighbors.Map(neighbor => neighbor.Pets).ToList();

            // Then
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[0].Count);
            Assert.AreEqual(0, result[1].Count);
            Assert.AreEqual(1, result[2].Count);
        }

        [TestMethod]
        public void TestShouldReturnList()
        {
            // Given

            // When
            var result = Return.List("Andrej", "Karina", "Natasha");

            // Then
            var list = result.ToList();

            Assert.AreEqual(3, list.Count());
            Assert.AreEqual("Andrej", list[0]);
            Assert.AreEqual("Karina", list[1]);
            Assert.AreEqual("Natasha", list[2]);
        }
    }
}