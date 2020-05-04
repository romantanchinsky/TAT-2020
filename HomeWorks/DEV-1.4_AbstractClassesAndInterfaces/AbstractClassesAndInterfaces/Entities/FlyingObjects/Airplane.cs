namespace AbstractClassesAndInterfaces.Entities.FlyingObjects
{
    public class Airplane : FlyingObject, IFlyable
    {
        private static uint STARTING_SPEED = 200;
        private static double ACCELERATION_DISTANCE = 10;
        private static double ACCELERATION = 10;

        public Airplane ( Coordinate theCoordinate )
           : base(theCoordinate)
        { }

        public void FlyTo ( Coordinate NewPosition )
        {
            CurrentPosition = NewPosition;
        }

        public double GetFlyTime ( Coordinate coordinate )
        {
            double distance = GetDistance(CurrentPosition, coordinate);
            double time = 0.0;
            for ( double currentSpeed = STARTING_SPEED; distance > 0; distance -= ACCELERATION_DISTANCE, currentSpeed += ACCELERATION )
            {
                time += ACCELERATION_DISTANCE / currentSpeed;
            }
            return time;
        }
    }
}
