using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;

namespace CarPark.Factory
{
    internal class CarWithManualTransmissionCreator : IVehicleCreator
    {
        public Vehicle FactoryMethod ()
        {
            return new PassengerCar(new Engine(200.0, 200.0, "Type", "2"), new Chassis(4, "2", 200.0), new Transmission("Manual", 4, 200.0), "Green");
        }
    }
}
