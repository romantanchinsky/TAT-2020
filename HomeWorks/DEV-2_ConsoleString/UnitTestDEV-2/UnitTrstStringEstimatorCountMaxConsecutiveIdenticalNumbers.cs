using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2_ConsoleString;

namespace UnitTestDEV_2
{
    [TestClass]
    public class UnitTrstStringEstimatorCountMaxConsecutiveIdenticalNumbers
    {
        StringEstimator stringEstimator = new StringEstimator();

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNull()
        {
            stringEstimator.CountMaxConsecutiveIdenticalNumbers(null);
        }

        [TestMethod]
        public void TestStringEmpty()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalNumbers(String.Empty), 0);
        }

        [TestMethod]
        public void TestBoundaryConditionZero()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalNumbers("//////////1110000"), 4);
        }

        [TestMethod]
        public void TestRightBoundaryConditionNine()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalNumbers("88889999999999:::::::::::"), 10);
        }
    }
}
