using NUnit.Framework;
using Text;

namespace Text.Tests
{
	[TestFixture]
    public class Tests
    {
        [Test]
        public void CamelCase()
        {
			string test = "helloMyNameIs";
			int result = Str.CamelCase(test);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CamelCaseOneWord()
        {
			string test = "hello";
			int result = Str.CamelCase(test);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCaseTwoWords()
        {
			string test = "helloMy";
			int result = Str.CamelCase(test);
            Assert.AreEqual(2, result);
		}

        [Test]
        public void CamelCaseEmptyString()
        {
			string test = "";
			int result = Str.CamelCase(test);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCaseNull()
        {
			int result = Str.CamelCase(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCaseTwoFollowed()
        {
			string test = "helloIAmHere";
			int result = Str.CamelCase(test);
            Assert.AreEqual(4, result);
		}
    }
}
