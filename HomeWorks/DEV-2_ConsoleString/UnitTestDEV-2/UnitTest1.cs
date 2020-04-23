using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2_ConsoleString;

namespace UnitTestDEV_2
{
    [TestClass]
    public class UnitTest1
    {
        StringEstimator stringEstimator = new StringEstimator();

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetMaxSequenceArgumentNull ()
        {
            stringEstimator.CountMaxConsecutiveUnequalSymbols(null);
        }

        [TestMethod]
        public void TestGetMaxSequenceArgumentStringEmpty ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols(String.Empty), 0);
        }

        [TestMethod]
        public void TestGetMaxSequenceOneCharacterArgument ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("a"), 1);
        }

        [TestMethod]
        public void TestGetMaxSequenceTwoDifferentChatacterArgument ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("1="), 1);
        }

        [TestMethod]
        public void TestGetMaxSequenceTwoSameChatacterArgument ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("gg"), 2);
        }

        [TestMethod]
        public void TestGetMaxSequenceInTheBeginn ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("ssss1234560;fmrddopeee"), 4);
        }

        [TestMethod]
        public void TestGetMaxSequenceInTheEnd ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("aaqwrbt5555[[[[["), 5);
        }
    }
}
