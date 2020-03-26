using System;

namespace AbstractClassesAndInterfaces.Entitys
{
    public class Drone : FlyingObject, IFlyable
    {
        private static double MAX_DISTANCE = 1000.0;
        protected static double CONSTANT_SPEED = 20.0;
        public static string EXCEPTION_MESSAGE = $"Drone flight impossible for more than {MAX_DISTANCE} km";
        

        public Drone ( Coordinate theCoordinate )
            : base(theCoordinate)
        { }

        public void FlyTo ( Coordinate NewPosition )
        {
            if ( GetDistance(CurrentPosition, NewPosition) > 1000 )
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
            }
            CurrentPosition = NewPosition;
        }
        public double GetFlyTime ( Coordinate coordinate )
        {
            double distance = GetDistance(CurrentPosition, coordinate);
            if ( distance > MAX_DISTANCE )
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
            }
            return distance / CONSTANT_SPEED + Math.Floor( ( distance / CONSTANT_SPEED ) / 10.0 );
        }
    }
}
