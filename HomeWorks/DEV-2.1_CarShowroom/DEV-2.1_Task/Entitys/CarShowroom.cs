using DEV_2._1_Task.DataBase;
using DEV_2._1_Task.Enums;
using System;

namespace DEV_2._1_Task.Entitys
{
    public class CarShowroom
    {
        private static CarShowroom _instance;
        private XmlProvider _provider;

        private CarShowroom()
        {
            _provider = XmlProvider.GetInstance();
        }

        public EventHandler<string> MethodExecute;

        public static CarShowroom GetInstance()
        {
            if ( _instance == null)
            {
                _instance = new CarShowroom();
            }
            return _instance;
        }

        public void CountBrands()
        {
            MethodExecute?.Invoke(this, _provider.GetBrandsCount().ToString());
        }

        public void CounAll()
        {
            MethodExecute?.Invoke(this, _provider.GetCarsCount().ToString());
        }

        public void AveragePrice()
        {
            MethodExecute?.Invoke(this, _provider.GetAveragePrice().ToString());
        }

        public void AveragePriceType(string brand)
        {
            MethodExecute?.Invoke(this, _provider.GetBrandAveragePrice(brand).ToString());
        }

        public void AddCars(string[] arguments)
        {
            if (arguments.Length == 4)
            {
                for (int i = 0; i < int.Parse(arguments[3]); i++)
                {
                    _provider.AddCar(new Car
                        (
                            (BrandEnum)Enum.Parse(typeof(BrandEnum), arguments[0]),
                            (ModelEnum)Enum.Parse(typeof(ModelEnum), arguments[1]),
                            double.Parse(arguments[2])
                        ));
                }
            }
        }
    }
}
