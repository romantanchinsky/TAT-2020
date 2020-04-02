using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;
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
            CarWithAutomaticTransmissionAndGasEngineCreator carWithAutomaticTransmissionAndGasEngineCreator = new CarWithAutomaticTransmissionAndGasEngineCreator();
            AddVehicles(vehicles, carWithAutomaticTransmissionAndGasEngineCreator, 2);

            CarWithManualTransmissionCreator carWithManualTransmissionCreator = new CarWithManualTransmissionCreator();
            AddVehicles(vehicles, carWithManualTransmissionCreator, 3);

            BusWithFortyFiveSeatsCreator busWithFortyFiveSeatsCreator = new BusWithFortyFiveSeatsCreator();
            AddVehicles(vehicles, busWithFortyFiveSeatsCreator, 2);

            TruckWithManualTransmission truckWithManualTransmission = new TruckWithManualTransmission();
            AddVehicles(vehicles, truckWithManualTransmission, 2);

            foreach ( var vehicle in vehicles )
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        static void AddVehicles( List<Vehicle> vehicles, IVehicleCreator creator, int numberOfVehicles )
        {
            for ( int i = 0; i < numberOfVehicles; i++ )
            {
                vehicles.Add(creator.FactoryMethod());
            }
        }
    }
}
