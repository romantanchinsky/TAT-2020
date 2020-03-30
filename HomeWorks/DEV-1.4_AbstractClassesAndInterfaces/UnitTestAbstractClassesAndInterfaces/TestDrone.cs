using System;
using AbstractClassesAndInterfaces.Entitys;
using AbstractClassesAndInterfaces.Entitys.FlyingObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAbstractClassesAndInterfaces
{
    [TestClass]
    public class TestDrone
    {
        private static double MAX_DISTANCE = 1000.0;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestFlyToExcessOfDistance ()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.FlyTo(new Coordinate(1002, 1, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositiveTestFlyToExcessOfDistance ()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.FlyTo(new Coordinate(500, 1, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeTestGetFlyTimeExcessOfDistance ()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.GetFlyTime(new Coordinate(1002, 1, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositiveTestGetFlyTimeExcessOfDistance ()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.GetFlyTime(new Coordinate(500, 1, 1));
        }
    }
}
