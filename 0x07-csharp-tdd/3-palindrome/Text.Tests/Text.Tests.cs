using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTrue()
        {
            string test = "beeb";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestFalse()
        {
            string test = "boeb";
            bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestSpecialChar()
        {
            string test = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void EmptyString()
        {
            string test = "";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestUppercase()
        {
            string test = "Racecar";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNumber()
        {
            string test = "01010";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNumberAndCharFalse()
        {
            string test = "01No010";
            bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestNumberAndCharTrue()
        {
            string test = "01No0on10";
            bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestUppercaseFalse()
        {
            string test = "NoPalindoMe";
            bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
        }

    }
}
