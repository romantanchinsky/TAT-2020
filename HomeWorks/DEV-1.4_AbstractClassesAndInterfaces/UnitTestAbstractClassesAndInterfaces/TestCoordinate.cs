using System;
using AbstractClassesAndInterfaces.Entitys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAbstractClassesAndInterfaces
{
    [TestClass]
    public class TestCoordinate
    {
        private static double NUMBER_ZERO = 0.0;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestSetXZero ()
        {
            new Coordinate(NUMBER_ZERO, 1.0, 10.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestSetYZero ()
        {
            new Coordinate(780.0, NUMBER_ZERO, 10.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestSetZZero ()
        {
            new Coordinate(46.0, 1.0, NUMBER_ZERO);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestSetYNegativeNumber ()
        {
            new Coordinate(6.0, -81.0, 3.6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositiveTestSetXYZOne ()
        {
            new Coordinate(1.0, 1.0, 0.0);
        }
    }
}
