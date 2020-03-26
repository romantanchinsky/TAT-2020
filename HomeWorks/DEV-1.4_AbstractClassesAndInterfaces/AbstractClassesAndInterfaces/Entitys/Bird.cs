﻿using System;

namespace AbstractClassesAndInterfaces.Entitys
{
    public class Bird : FlyingObject, IFlyable
    {
        public uint Speed { get; protected set; }
        public Bird ( Coordinate theCoordinate ) 
            : base (theCoordinate)
        {
            Random random = new Random();
            Speed = (uint)random.Next(20);
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
