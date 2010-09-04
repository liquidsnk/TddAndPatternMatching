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
    }
}
