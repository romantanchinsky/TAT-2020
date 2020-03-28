using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;
using System;
using System.Collections.Generic;

namespace CarPark
{
    class EntryPoint
    {
        static void Main ( string [] args )
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Bus(new Engine(1.0, 1.0, "type", "serialNumber"), new Chassis(1, "number", 1.0), new Transmission("type", 1, 1.0), 1));
            vehicles.Add(new PassengerCar(new Engine(2.0, 2.0, "type", "serialNumber"), new Chassis(2, "number", 2.0), new Transmission("type", 2, 2.0), "color"));
            vehicles.Add(new Scooter(new Engine(3.0, 3.0, "type", "serialNumber"), new Chassis(3, "number", 3.0), new Transmission("type", 3, 3.0), 3));
            vehicles.Add(new Truck(new Engine(4.0, 4.0, "type", "serialNumber"), new Chassis(4, "number", 4.0), new Transmission("type", 4, 4.0), 4));

            foreach ( var vehicle in vehicles )
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
