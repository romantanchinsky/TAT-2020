using System;

namespace AbstractClassesAndInterfaces.Entitys
{
    public class Coordinate
    {
        public static string EXCEPTION_MESSAGE = "Coordinate can only be positive";

        private double _x;
        public double X
        {
            get => _x;
            set
            {
                if ( !IsPositive(value) )
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
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
                if ( !IsPositive(value) )
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
                }
                _y = value;
            }
        }

        private double _z;
        public double Z
        {
            get => _z;
            set
            {
                if ( !IsPositive(value) )
                {
                    throw new ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
                }
                _z = value;
            }
        }

        public Coordinate ( double theX, double theY, double theZ )
        {
            X = theX;
            Y = theY;
            Z = theZ;
        }

        private bool IsPositive ( double number )
        {
            return number > 0;
        }
    }
}
