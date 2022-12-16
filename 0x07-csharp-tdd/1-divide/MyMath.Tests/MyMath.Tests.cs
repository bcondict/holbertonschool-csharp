using NUnit.Framework;
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
        public void DivideMatrixEven()
        {
            int [,] test = new int[,] {{2, 4}, {6, 8}};
            int [,] expected = new int[,] {{1, 2}, {3, 4}};
            int [,] result = Matrix.Divide(test, 2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivideMatrixOdd()
        {
            int [,] test = new int[,] {{3, 5}, {7, 9}};
            int [,] expected = new int[,] {{1, 2}, {3, 4}};
            int [,] result = Matrix.Divide(test, 2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivideMatrixZero()
        {
            int [,] test = new int[,] {{3, 5}, {7, 9}};
            int [,] result = Matrix.Divide(test, 0);

            Assert.IsNull(result);
        }
        [Test]
        public void DivideMatrixNull()
        {
            int [,] result = Matrix.Divide(null, 2);

            Assert.IsNull(result);
        }

        [Test]
        public void DivideMatrixNegativeBy2()
        {
            int [,] test = new int[,] {{-2, -4}, {-6, -8}};
            int [,] expected = new int[,] {{-1, -2}, {-3, -4}};
            int [,] result = Matrix.Divide(test, 2);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivideMatrixNumberByNegative()
        {
            int [,] test = new int[,] {{2, 4}, {6, 8}};
            int [,] expected = new int[,] {{-1, -2}, {-3, -4}};
            int [,] result = Matrix.Divide(test, -2);

            Assert.AreEqual(expected, result);
        }
    }
}
