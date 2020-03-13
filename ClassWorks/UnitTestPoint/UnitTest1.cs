using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Points;

namespace UnitTestPoint
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetXTrue ()
        {
            Point point = new Point(0.0, 5.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetXFalse ()
        {
            Point point = new Point(-0.1, 5.0);
        }

        [TestMethod]
        public void TestSetYTrue ()
        {
            Point point = new Point(4.0, 5.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetYFalse ()
        {
            Point point = new Point(0.1, -5.0);
        }

        [TestMethod]
        public void TestEqualsTrue ()
        {
            Point point = new Point(0.0, 0.0);
            Assert.IsTrue(point.Equals(point) );
        }

        [TestMethod]
        public void TestEqualsFalse ()
        {
            Assert.IsFalse(new Point(1.0, 1.0).Equals(new Point(1.0, 2.0)));
        }

        [TestMethod]
        public void TestEqualsNull ()
        {
            Assert.IsFalse(new Point(99.0,74.0).Equals(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestPlusFirstArgumentNull ()
        {
            var result = new Point(8.0, 1.0) + null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestPlusSecondArgumentNull ()
        {
            var result = null + new Point(1.0, 35.0);
        }

        [TestMethod]
        public void TestPlusTrue ()
        {
            Assert.AreEqual(new Point(1.0, 1.0) + new Point(2.0, 2.0), new Point(3.0, 3.0));
        }

        [TestMethod]
        public void TestPlusFalse ()
        {
            Assert.AreNotEqual(new Point(3.0, 3.0) + new Point(2.0, 2.0), new Point(4.0, 5.0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMinusFirstArgumentNull ()
        {
            var result = new Point(1.0, 65.0) - null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMinusSecondArgumentNull ()
        {
            var result = null + new Point(106.0, 1.0);
        }

        [TestMethod]
        public void TestMinusTrue ()
        {
            Assert.AreEqual(new Point(4.0, 4.0) - new Point(2.0, 2.0), new Point(2.0, 2.0));
        }

        [TestMethod]
        public void TestMinusFalse ()
        {
            Assert.AreNotEqual(new Point(5.0, 5.0) - new Point(2.0, 2.0), new Point(4.0, 3.0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMinusOutOfRange ()
        {
            var result = new Point(1.0, 1.0) - new Point(2.0, 2.0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetDistanceNull ()
        {
            new Point(143.0, 65.0).GetDistanсe(null);
        }

        [TestMethod]
        public void TestGetDistanceTrue ()
        {
            Assert.IsTrue(Math.Abs(new Point(50.0, 0.0).GetDistanсe(new Point(0.0,50.0)) - Math.Sqrt(5000.0)) < 0.000001);
        }
    }
}
