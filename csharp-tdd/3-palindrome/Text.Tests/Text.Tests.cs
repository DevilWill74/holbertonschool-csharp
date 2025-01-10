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
            string word = "yay";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void TestNotPal()
        {
            string word = "yays";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(false, output);
        }

        [Test]
        public void TestEmpty()
        {
            string word = "";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void Test1Letter()
        {
            string word = "y";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void TestPuncLowercaseSpaces()
        {
            string word = "A man, a plan, a canal: Panama.";

            bool output = Str.IsPalindrome(word);

            Assert.AreEqual(true, output);
        }
    }
}