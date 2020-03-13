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
            stringEstimator.GetMaxSequence(null);
        }

        [TestMethod]
        public void TestGetMaxSequenceArgumentStringEmpty ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence(String.Empty), 0);
        }

        [TestMethod]
        public void TestGetMaxSequenceOneCharacterArgument ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence("a"), 1);
        }

        [TestMethod]
        public void TestGetMaxSequenceTwoDifferentChatacterArgument ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence("1="), 1);
        }

        [TestMethod]
        public void TestGetMaxSequenceTwoSameChatacterArgument ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence("gg"), 2);
        }

        [TestMethod]
        public void TestGetMaxSequenceInTheBeginn ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence("ssss1234560;fmrddopeee"), 4);
        }

        [TestMethod]
        public void TestGetMaxSequenceInTheEnd ()
        {
            Assert.AreEqual(stringEstimator.GetMaxSequence("aaqwrbt5555[[[[["), 5);
        }
    }
}
