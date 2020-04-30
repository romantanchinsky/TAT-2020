using CarPark.Entities.Cars;

namespace CarPark.Factory
{
    internal interface IFactory
    {
        Vehicle CreateBus();

        Vehicle CreatePassengerCar();

        Vehicle CreateScooter();

        Vehicle CreateTruck();
    }
}