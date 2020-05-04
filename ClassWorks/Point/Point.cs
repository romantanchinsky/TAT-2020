using System;

namespace Points
{
    public class Point
    {
        public const string EXCEPTION_NULL_MESSAGE = "Null parametr";
        public const string EXCEPTION_OUT_OF_RANGE_MESSAGE = "Incorrect parametr";
        public const string EXCEPTION_MINUS_MESSAGE = "Negative sum";
        
        private double _x;
        public double X
        {
            get => _x;
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_OUT_OF_RANGE_MESSAGE); 
                }
                _x = value;
            }

        }

        private double _y;
        public double Y
        {
            get => _y;
            set
            {
                if ( value < 0 ) 
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_OUT_OF_RANGE_MESSAGE); 
                }
                _y = value; 
            }
        }

        public Point ( double theX, double theY )
        {
            X = theX;
            Y = theY;
        }

        public override bool Equals ( object obj )
        {
            return (obj as Point)?.X == X && (obj as Point)?.Y == Y;
        }

        public double GetDistanсe ( Point point )
        {
            if ( point != null )
            {
                return Math.Sqrt(( point.X - X ) * ( point.X - X ) + ( point.Y - Y ) * ( point.Y - Y ));
            }
            throw new ArgumentNullException(EXCEPTION_NULL_MESSAGE);
        }

        public static Point operator + ( Point first, Point second )
        {
            if ( first == null || second == null )
            {
                throw new ArgumentNullException(EXCEPTION_NULL_MESSAGE);
            }
            return new Point(first.X + second.X, first.Y + second.Y);
        }

        public static Point operator - ( Point first, Point second )
        {
            if ( first == null || second == null )
            {
                throw new ArgumentNullException(EXCEPTION_NULL_MESSAGE);
            }
            if ( ( first.X - second.X < 0 ) || ( first.Y - second.Y < 0 ) )
            {
                throw new ArgumentOutOfRangeException(EXCEPTION_MINUS_MESSAGE); 
            }
            return new Point(first.X - second.X, first.Y - second.Y);
        }
    }
}
