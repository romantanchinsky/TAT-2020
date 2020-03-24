using System;
using CarPark;
using CarPark.Entitys.Spares;
using CarPark.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCarPark
{
    [TestClass]
    public class UnitTestChecker
    {
        Checker checker = new Checker();

        [TestMethod]
        public void TestIsLatinLettersAndNumbersNull ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers(null));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersEmptyString ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers(String.Empty));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersTrue()
        {
            Assert.IsTrue(checker.IsLatinLettersAndNumbers("09AZaz5Gd"));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidCondition1 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers("//"));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidCondition2 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers(":"));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidConditio31 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers("@"));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidCondition4 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers("["));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidCondition5 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers("`"));
        }

        [TestMethod]
        public void TestIsLatinLettersAndNumbersBoundaryInvalidCondition6 ()
        {
            Assert.IsFalse(checker.IsLatinLettersAndNumbers("{"));
        }
    }

    [TestClass]
    public class UnitTestSeters
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfLatinLettersAndNumbersRangeException))]
        public void TestEngineTypeSetException ()
        {
            Engine engine = new Engine(1.2, 5.4, "#", "322");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfLatinLettersAndNumbersRangeException))]
        public void TestChasisNumberSetException ()
        {
            Chassis chassis = new Chassis(1, "&", 1.6 );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfLatinLettersAndNumbersRangeException))]
        public void TestTransmissionTypeSetException ()
        {
            Transmission transmission = new Transmission(" ", 6, 7.7);
        }
    }
}
