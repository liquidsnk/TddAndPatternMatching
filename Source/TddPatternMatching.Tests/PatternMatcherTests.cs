using System;

using NUnit.Framework;

namespace TddPatternMatching.Tests
{
    [TestFixture]
    public class PatternMatcherTests
    {
        [Test]
        public void GetCount_WhenSubstringNotPresent_ReturnsZero()
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.AreEqual(0, sut.GetCount("z"));
        }

        [Test]
        [TestCase("a", 5)]
        [TestCase("ab", 2)]
        [TestCase("ra", 2)]
        [TestCase("abra", 2)]
        public void GetCount_WhenSubstringIsPresent_ReturnsCount(string subString, int expectedCount)
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.AreEqual(expectedCount, sut.GetCount(subString));
        }

        [Test]
        public void Constructor_WhenGivenNullText_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PatternMatcher(null));
        }
    }
}
