using DEV_2._1_Task.DataBase;
using DEV_2._1_Task.Enums;
using System;

namespace DEV_2._1_Task.Entitys
{
    public class CarConvertor
    {
        private XmlProvider _provider;

        public CarConvertor()
        {
            _provider = XmlProvider.GetInstance();
        }

        public CarDB Convert(Car car)
        {
            return new CarDB(_provider.GetBrandId(car.Brand),
                             _provider.GetModelId(car.Model),
                             car.Price);
        }

        public Car Convert(CarDB carDB)
        {
            return new Car((BrandEnum)Enum.Parse(typeof(BrandEnum), _provider.GetBrandName(carDB.BrandID)),
                           (ModelEnum)Enum.Parse(typeof(ModelEnum), _provider.GetModelName(carDB.ModelID)),
                           carDB.Price);
        }
    }
}
