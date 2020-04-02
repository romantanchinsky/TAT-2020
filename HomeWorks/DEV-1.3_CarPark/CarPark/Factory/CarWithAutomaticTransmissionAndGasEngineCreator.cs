using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;

namespace CarPark.Factory
{
    internal class CarWithAutomaticTransmissionAndGasEngineCreator : IVehicleCreator
    {
        public Vehicle FactoryMethod()
        {
            return new PassengerCar(new Engine(100.0, 100.0, "Gas", "1"), new Chassis(4, "1", 100.0), new Transmission("Automatic", 4, 100.0), "Blue"); 
        }
    }
}
