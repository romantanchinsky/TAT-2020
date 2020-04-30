using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2_ConsoleString;

namespace UnitTestDEV_2
{
    [TestClass]
    public class UnitTestStringEstimatorCountMaxConsecutiveIdenticalLatinLetters
    {
        StringEstimator stringEstimator = new StringEstimator();

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNull()
        {
            stringEstimator.CountMaxConsecutiveIdenticalLatinLetters(null);
        }

        [TestMethod]
        public void TestStringEmpty()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveUnequalSymbols(String.Empty), 0);
        }

        [TestMethod]
        public void TestOneCorrectSymbol()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalLatinLetters("a"), 1);
        }

        [TestMethod]
        public void TestMaxConsecutiveIdenticalAtTheBeginning()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalLatinLetters("zzz{{{{uu"), 3);
        }

        [TestMethod]
        public void TestMaxConsecutiveIdenticalAtTheEnd()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalLatinLetters("eee68fv)@@@@@@#AAAAA"), 5);
        }

        [TestMethod]
        public void TestBoundaryPermissibleValueSymbolZ()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalLatinLetters("rrZZZZZZZZZZ[[[[[[[[[[[41555ebbb"), 10);
        }

        [TestMethod]
        public void TestOnlyIncorrectBoundarySymbols()
        {
            Assert.AreEqual(stringEstimator.CountMaxConsecutiveIdenticalLatinLetters("?@[\\_`{|"), 0);
        }
    }
}
