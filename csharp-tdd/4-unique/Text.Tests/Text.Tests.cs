using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string testWord = "ooooook";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(6, output);
        }
        
        [Test]
        public void TestEmpty()
        {
            string testWord = "";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(-1, output);
        }

        [Test]
        public void TestBeginning()
        {
            string testWord = "kooooo";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(0, output);
        }

        [Test]
        public void TestNoNew()
        {
            string testWord = "ooooooo";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(-1, output);
        }

        [Test]
        public void TestEnd()
        {
            string testWord = "ooooook";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(6, output);
        }

        [Test]
        public void TestMiddle()
        {
            string testWord = "oookoo";
            int output = Str.UniqueChar(testWord);

            Assert.AreEqual(3, output);
        }
    }
}