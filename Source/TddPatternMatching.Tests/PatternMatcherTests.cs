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

        [Test]
        public void GetCount_WhenGivenSubstringLongerThanText_ReturnsZero()
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.AreEqual(0, sut.GetCount("abra kadabra kabra"));
        }

        [Test]
        public void GetCount_WhenGivenNullSubstring_ThrowsArgumentNullException()
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.Throws<ArgumentNullException>(() => sut.GetCount(null));
        }

        //I've purposely avoided dealing with the "empty" string here, since I don't know what I should theoretically do with it.
        //Is the empty string a subString of every string or not?, etc.

        [Test]
        public void GetIndexes_WhenGivenNullSubstring_ThrowsArgumentNullException()
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.Throws<ArgumentNullException>(() => sut.GetIndexes(null));
        }

        [Test]
        public void GetIndexes_WhenSubstringNotPresent_ReturnsEmptyCollection()
        {
            var sut = new PatternMatcher("abra kadabra");
            Assert.AreEqual(0, sut.GetIndexes("z").Count);
        }
    }
}
