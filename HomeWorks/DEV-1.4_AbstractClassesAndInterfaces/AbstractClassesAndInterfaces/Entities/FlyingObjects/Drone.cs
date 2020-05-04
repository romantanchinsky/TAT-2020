using System;

namespace AbstractClassesAndInterfaces.Entities.FlyingObjects
{
    public class Drone : FlyingObject, IFlyable
    {
        private static double TIME_BETWEEN_STOP = 1.0 / 6.0;
        private static double MAX_DISTANCE = 1000.0;
        private static double CONSTANT_SPEED = 20.0;
        public static string EXCEPTION_MESSAGE = $"Drone flight impossible for more than {MAX_DISTANCE} km";
        
        public Drone ( Coordinate theCoordinate )
            : base(theCoordinate)
        { }

        public void FlyTo ( Coordinate NewPosition )
        {
            if ( GetDistance(CurrentPosition, NewPosition) > MAX_DISTANCE )
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
            }
            CurrentPosition = NewPosition;
        }
        /// <param name="destination"></param>
        /// <returns>returns time in hours</returns>
        public double GetFlyTime ( Coordinate destination )
        {
            double distance = GetDistance(CurrentPosition, destination);
            if ( distance > MAX_DISTANCE )
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
            }
            double timeWithoutStop = distance / CONSTANT_SPEED;
            return timeWithoutStop < TIME_BETWEEN_STOP || timeWithoutStop % TIME_BETWEEN_STOP != 0 ? timeWithoutStop + Math.Floor(timeWithoutStop / TIME_BETWEEN_STOP) : timeWithoutStop + Math.Floor(timeWithoutStop / TIME_BETWEEN_STOP) - 1;
        }
    }
}
