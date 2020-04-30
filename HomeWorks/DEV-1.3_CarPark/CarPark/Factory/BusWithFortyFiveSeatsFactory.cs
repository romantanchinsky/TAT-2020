using System;
using CarPark.Entities.Cars;
using CarPark.Entities.Spares;

namespace CarPark.Factory
{
    class BusWithFortyFiveSeatsFactory : IFactory
    {
        private const string TRANSMISSION_TYPE = "Manual",
                             ENGINE_TYPE = "EType",
                             ENGINE_SERIAL_NUMBER = "1",
                             CHASSIS_NUMBER = "1";
        private const double POWER = 300.0,
                             CAPACITY = 300.0,
                             PERMISSIBLE_LOAD = 200.0,
                             PERFORMANSE = 200.0;
        private const uint CARS_WHEELS_NUMBER = 4,
                           GEARS_NUMBER = 4,
                           BUS_SEATS_NUMBER = 45;

        public Vehicle CreateBus ()
        {
            return new Bus(new Engine(POWER, CAPACITY, ENGINE_TYPE, ENGINE_SERIAL_NUMBER), new Chassis(CARS_WHEELS_NUMBER, CHASSIS_NUMBER, PERMISSIBLE_LOAD), new Transmission(TRANSMISSION_TYPE, GEARS_NUMBER, PERFORMANSE), BUS_SEATS_NUMBER);
        }

        public Vehicle CreatePassengerCar()
        {
            throw new ProductException();
        }

        public Vehicle CreateScooter()
        {
            throw new ProductException();
        }

        public Vehicle CreateTruck()
        {
            throw new ProductException();
        }
    }
}
