using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] myMatrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };

            int[,] output = Matrix.Divide(myMatrix, 2);
            
            int[,] resultMatrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            Assert.AreEqual(resultMatrix, output);
        }

        [Test]
        public void divideBy0()
        {
            int[,] myMatrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };

            int[,] output = Matrix.Divide(myMatrix, 0);

            Assert.AreEqual(null, output);
        }
        
        [Test]
        public void CheckNull()
        {
            int[,] myMatrix = null;
            int[,] output = Matrix.Divide(myMatrix, 9);
            Assert.AreEqual(null, output);
        }
    }
}