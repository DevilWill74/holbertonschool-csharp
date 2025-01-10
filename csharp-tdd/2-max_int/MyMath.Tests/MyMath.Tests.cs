using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(6);
            myList.Add(9);

            int output = Operations.Max(myList);

            Assert.AreEqual(9, output);
        }
        [Test]
        public void Test2()
        {
            List<int> myList = new List<int>();

            myList.Add(9);
            myList.Add(6);
            myList.Add(1);

            int output = Operations.Max(myList);

            Assert.AreEqual(9, output);
        }

        [Test]
        public void Test3()
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(9);
            myList.Add(6);

            int output = Operations.Max(myList);

            Assert.AreEqual(9, output);
        }

        [Test]
        public void Test4()
        {
            List<int> myList = new List<int>();

            myList.Add(-1);
            myList.Add(-6);
            myList.Add(-9);

            int output = Operations.Max(myList);

            Assert.AreEqual(-1, output);
        }

        [Test]
        public void Test5()
        {
            List<int> myList = new List<int>();

            int output = Operations.Max(myList);

            Assert.AreEqual(0, output);
        }
    }
}