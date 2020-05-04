﻿using AbstractClassesAndInterfaces.Entities;

namespace AbstractClassesAndInterfaces
{
    interface IFlyable
    {
        void FlyTo ( Coordinate coordinate );
        double GetFlyTime ( Coordinate coordinate );
    }
}
