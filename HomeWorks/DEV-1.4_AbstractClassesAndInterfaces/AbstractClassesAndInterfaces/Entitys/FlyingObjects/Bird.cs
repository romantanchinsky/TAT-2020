using System;

namespace AbstractClassesAndInterfaces.Entitys.FlyingObjects
{
    public class Bird : FlyingObject, IFlyable
    {
        public uint Speed { get; protected set; }
        public Bird ( Coordinate theCoordinate ) 
            : base (theCoordinate)
        {
            Speed = (uint)Randomizer.random.Next(1, 20);
        }

        public void FlyTo ( Coordinate NewPosition )
        {
            CurrentPosition = NewPosition;
        }

        public double GetFlyTime ( Coordinate coordinate )
        {
            return GetDistance(CurrentPosition, coordinate) / Speed;
        }
    }
}
