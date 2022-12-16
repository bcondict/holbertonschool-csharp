using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestList()
        {
            List<int> test = new List<int>() {1, 2, 3, 4, 5, 6};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, 6);
        }

        [Test]
        public void TestEmptyList()
        {
            List<int> test = new List<int>() {};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestEqualList()
        {
            List<int> test = new List<int>() {1, 1, 1, 1, 1};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TestNegativeList()
        {
            List<int> test = new List<int>() {-1, -2, -3, -4, -5, -6};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void TestNegativeAndPositiveList()
        {
            List<int> test = new List<int>() {-1, 2, -3, 4, -5, -6};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, 4);
        }

        [Test]
        public void TestOneElement()
        {
            List<int> test = new List<int>() {-6};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, -6);
        }

        [Test]
        public void TestGreaterIsZero()
        {
            List<int> test = new List<int>() {-5, -4, -3, -2, -1, 0};
            int result =  MyMath.Operations.Max(test);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestNull()
        {
            int result =  MyMath.Operations.Max(null);

            Assert.AreEqual(result, 0);
        }
    }
}
