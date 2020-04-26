using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2_ConsoleString;

namespace UnitTestDEV_2
{
    [TestClass]
    public class UnitTestStringEstimatorCountMaxConsecutiveUnequalSymbols
    {
        StringEstimator stringEstimator = new StringEstimator();

        [TestMethod]
        public void TestNull()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols(null), 0);
        }

        [TestMethod]
        public void TestStringEmpty()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols(String.Empty), 0);
        }

        [TestMethod]
        public void TestOneSymbol()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("="), 1);
        }

        [TestMethod]
        public void TestSeveralEqualSymbols()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("ppppppppppp"), 1);
        }

        [TestMethod]
        public void TestConsecutiveUnequalSymbolsAtTheBeginning()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("1234567893485"), 9);
        }

        [TestMethod]
        public void TestConsecutiveUnequalSymbolsAtTheEnd()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols("kljhbdskjyoh=-09"), 12);
        }
    }
}
