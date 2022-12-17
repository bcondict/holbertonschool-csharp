using NUnit.Framework;
using Text;

namespace Text.Tests
{
	[TestFixture]
    public class Tests
    {
        [Test]
        public void Unique()
        {
			string test = "uniq";
			int result = Str.UniqueChar(test);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueNotUnique()
        {
			string test = "hiahiahia";
			int result = Str.UniqueChar(test);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueEmpty()
        {
			string test = "";
			int result = Str.UniqueChar(test);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueOneChar()
        {
			string test = "h";
			int result = Str.UniqueChar(test);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueLast()
        {
			string test = "hihililia";
			int result = Str.UniqueChar(test);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void UniqueNull()
        {
			int result = Str.UniqueChar(null);
            Assert.AreEqual(-1, result);
        }
    }
}
