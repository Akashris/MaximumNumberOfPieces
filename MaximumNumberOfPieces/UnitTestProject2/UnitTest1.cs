using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberOfPieces;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EllipticalLand sock = new EllipticalLand();
            List<int> sockList = new List<int>()
            {1, 1, 2, 2, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            EllipticalLand sock = new EllipticalLand();
            List<int> sockList = new List<int>()
            {1, 1, 2, -4, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod3()
        {
            EllipticalLand sock = new EllipticalLand();
            List<int> sockList = new List<int>()
            {0,0,0,0,0};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod4()
        {
            EllipticalLand sock = new EllipticalLand();
            List<int> sockList = new List<int>()
            {0, -1, 2, 4, 3};
            int actual = sock.findDuplicates(sockList);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}
