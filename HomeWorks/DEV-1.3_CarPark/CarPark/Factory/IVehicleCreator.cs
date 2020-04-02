using CarPark.Entitys.Cars;

namespace CarPark.Factory
{
    internal interface IVehicleCreator
    {
        Vehicle FactoryMethod ();
    }
}