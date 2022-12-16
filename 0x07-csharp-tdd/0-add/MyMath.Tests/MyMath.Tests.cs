using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddEquals()
        {
            int result = MyMath.Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void AddNegative()
        {
            int result = MyMath.Operations.Add(-2, -1);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void AddNegativePositive()
        {
            int result = MyMath.Operations.Add(-1, 2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AddZero()
        {
            int result = MyMath.Operations.Add(0, 2);
            Assert.AreEqual(2, result);
        }
    }
}
