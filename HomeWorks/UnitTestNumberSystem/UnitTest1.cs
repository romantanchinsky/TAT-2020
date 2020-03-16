using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._2_NumberSystems;

namespace UnitTestNumberSystem
{
    [TestClass]
    public class UnitTest1
    {
        NumberConverter numberConverter = new NumberConverter();

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodConvertIncorrectSystemValueOne ()
        {
            numberConverter.Convert(100, 1);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodConvertIncorrectSystemTwentyOneValue ()
        {
            numberConverter.Convert(100, 21);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodConvertIncorrectSystemUintMaxValue ()
        {
            numberConverter.Convert(100, uint.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodConvertIncorrectSystemUintMinValue ()
        {
            numberConverter.Convert(100, uint.MinValue);
        }

        [TestMethod]
        public void TestMethodConvertCorrectSystemTwoValue ()
        {
            numberConverter.Convert(100, 2);
        }

        [TestMethod]
        public void TestMethodConvertCorrectSystemTwentyValue ()
        {
            numberConverter.Convert(100, 20);
        }

        [TestMethod]
        public void TestMethodConvertCorrectNumberIntMaxValue ()
        {
            Assert.AreEqual(numberConverter.Convert(int.MaxValue, 2), "1111111111111111111111111111111");
        }

        [TestMethod]
        public void TestMethodConvertCorrectNumberIntMinValue ()
        {
            Assert.AreEqual(numberConverter.Convert(int.MinValue, 15), "-C87E66B8");
        }

        [TestMethod]
        public void TestMethodConvertOutAllLatterSymbols ()
        {
            Assert.AreEqual(numberConverter.Convert(258064555, 17) + numberConverter.Convert(7179, 20), "ABCDEFGHIJ");
        }

        [TestMethod]
        public void TestMethodConvertOutAllDigitalSymbols ()
        {
            Assert.AreEqual(numberConverter.Convert(6053444, 9) + numberConverter.Convert(99, 11), "1234567890");
        }
    }
}