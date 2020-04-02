using System;
using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;

namespace CarPark.Factory
{
    class BusWithFortyFiveSeatsCreator : IVehicleCreator
    {
        public Vehicle FactoryMethod ()
        {
            return new Bus(new Engine(300.0, 300.0, "Type", "3"), new Chassis(4, "3", 300.0), new Transmission("Type", 4, 300.0), 45);
        }
    }
}
