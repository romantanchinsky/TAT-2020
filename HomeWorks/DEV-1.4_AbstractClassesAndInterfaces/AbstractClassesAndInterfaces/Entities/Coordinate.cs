using System;

namespace AbstractClassesAndInterfaces.Entities
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
                if ( !IsPermissible(value) )
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
                if ( !IsPermissible(value) )
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
                if ( !IsPermissible(value) )
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

        private bool IsPermissible ( double coordinate )
        {
            return coordinate >= 0;
        }
    }
}
