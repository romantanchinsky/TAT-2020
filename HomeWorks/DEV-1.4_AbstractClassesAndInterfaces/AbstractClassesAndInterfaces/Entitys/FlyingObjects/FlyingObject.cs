using System;

namespace AbstractClassesAndInterfaces.Entitys.FlyingObjects
{
    public abstract class FlyingObject
    {
        public Coordinate CurrentPosition { get; protected set; }

        public FlyingObject ( Coordinate theCoordinate )
        {
            CurrentPosition = theCoordinate;
        }

        protected double GetDistance ( Coordinate firstCoordinate, Coordinate secondCoordinate )
        {
            return Math.Sqrt(Math.Pow(( firstCoordinate.X - secondCoordinate.X ), 2) + Math.Pow(( firstCoordinate.Y - secondCoordinate.Y ), 2) + Math.Pow(( firstCoordinate.Z - secondCoordinate.Z ), 2));
        }
    }
}
