using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberOfPieces;
using System.Collections.Generic;
using System.Numerics;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EllipticalLand obj = new EllipticalLand();
            List<BigInteger> numberOfPoints = new List<BigInteger>()
            {1, 2, 3, 4, 5};
            int actual = obj.CalculationMaximumPieces(numberOfPoints);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(2);
            List<BigInteger> expected.Add(4);
            List<BigInteger> expected.Add(8);
            List<BigInteger> expected.Add(16);
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            EllipticalLand obj = new EllipticalLand();
            List<BigInteger> numberOfPoints = new List<BigInteger>()
            {1, 1, 2, -4, 3};
            int actual = obj.CalculationMaximumPieces(numberOfPoints);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(2);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(4);
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod3()
        {
            EllipticalLand obj = new EllipticalLand();
            List<BigInteger> numberOfPoints = new List<BigInteger>()
            {0,0,0,0,0};
            int actual = obj.CalculationMaximumPieces(numberOfPoints);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(1);
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod4()
        {
            EllipticalLand obj = new EllipticalLand();
            List<BigInteger> numberOfPoints = new List<BigInteger>()
            {0, -1, 2, 4, 3};
            int actual = obj.CalculationMaximumPieces(numberOfPoints);
            List<BigInteger> expected.Add(1);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(2);
            List<BigInteger> expected.Add(8);
            List<BigInteger> expected.Add(4)
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod5()
        {
            EllipticalLand obj = new EllipticalLand();
            List<BigInteger> numberOfPoints = new List<BigInteger>()
            {-1,-2,-3,-4,-5};
            int actual = obj.CalculationMaximumPieces(numberOfPoints);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(-1);
            List<BigInteger> expected.Add(-1);
            Assert.AreEqual(expected, actual);
        }
    }
}
