using CarPark.Entities.Cars;
using System;
using System.Collections.Generic;
using CarPark.Factory;

namespace CarPark
{
    class EntryPoint
    {
        static void Main ( string [] args )
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            AutomaticTransmissionAndGasEngineFactory automaticTransmissionAndGasEngineFactory = new AutomaticTransmissionAndGasEngineFactory();
            ManualTransmissionFactory manualTransmissionFactory = new ManualTransmissionFactory();
            BusWithFortyFiveSeatsFactory busWithFortyFiveSeatsCreator = new BusWithFortyFiveSeatsFactory();

            AddVehicles(vehicles, 2, automaticTransmissionAndGasEngineFactory.CreatePassengerCar);
            AddVehicles(vehicles, 3, manualTransmissionFactory.CreatePassengerCar);
            AddVehicles(vehicles, 2, busWithFortyFiveSeatsCreator.CreateBus);
            AddVehicles(vehicles, 2, manualTransmissionFactory.CreateTruck);
            foreach ( var vehicle in vehicles )
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        static void AddVehicles(List<Vehicle> vehicles, int numberOfVehicles, Func<Vehicle> vehicleCreator)
        {
            for ( int i = 0; i < numberOfVehicles; i++ )
            {
                vehicles.Add(vehicleCreator());
            }
        }
    }
}
