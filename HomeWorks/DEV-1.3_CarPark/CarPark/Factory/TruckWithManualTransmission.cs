using CarPark.Entitys.Cars;
using CarPark.Entitys.Spares;

namespace CarPark.Factory
{
    class TruckWithManualTransmission : IVehicleCreator
    {
        public Vehicle FactoryMethod ()
        {
            return new Truck(new Engine(500.0, 500.0, "Type", "5"), new Chassis(4, "5", 500.0), new Transmission("Manual", 4, 200.0), 500);
        }
    }
}
