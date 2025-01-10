using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests if Add method is working correctly.</summary>
    public class Tests
    {
        [Test]
        /// <summary>Testing with positive numbers.</summary>
        public void Test1()
        {
            int sum = Operations.Add(7, 8);
            Assert.AreEqual(15, sum);
        }

        [Test]
        /// <summary> Testing with one negative number.</summary>
        public void Test2()
        {
            int sum = Operations.Add(-7, 8);
            Assert.AreEqual(1, sum);
        }

        [Test]
        /// <summary>Testing with negative numbers.</summary>
        public void Test3()
        {
            int sum = Operations.Add(-7, -8);
            Assert.AreEqual(-15, sum);
        }
    }
}