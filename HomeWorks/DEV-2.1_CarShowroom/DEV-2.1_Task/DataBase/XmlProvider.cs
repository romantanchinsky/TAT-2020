using DEV_2._1_Task.Entitys;
using DEV_2._1_Task.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1_Task.DataBase
{
    public class XmlProvider
    {
        private static XmlProvider _instance;

        private const string PATH_BRAND_FILE = "../../DataBase/XmlFiles/BrandDataBase.xml",
                             PATH_MODEL_FILE = "../../DataBase/XmlFiles/ModelDataBase.xml",
                             PATH_MAIN_FILE = "../../DataBase/XmlFiles/MainDataBase.xml",
                             ATTRIBUTE_ID = "id",
                             NAME_OF_PRICE = "Price",
                             NAME_OF_BRAND_ID = "BrandID",
                             NAME_OF_MODEL_ID = "ModelID",
                             NAME_OF_CAR_DB = "CarDB";

        private XDocument _xBrands = XDocument.Load(PATH_BRAND_FILE),
                          _xModels = XDocument.Load(PATH_MODEL_FILE),
                          _xMain = XDocument.Load(PATH_MAIN_FILE);

        private double GetTotalPrice(IEnumerable<double> prices)
        {
            double totalPrice = 0;
            foreach (var price in prices)
            {
                totalPrice += price;
            }
            return totalPrice;
        }

        private XmlProvider()
        { }

        public static XmlProvider GetInstance()
        {
            if (_instance == null)
            {
                _instance = new XmlProvider();
            }
            return _instance;
        }

        public string GetBrandName(int id)
        {
            return _xBrands.Root.Elements().Single(element => int.Parse(element.Attribute(ATTRIBUTE_ID).Value) == id).Value;
        }

        public string GetModelName(int id)
        {
            return _xModels.Root.Elements().Single(element => int.Parse(element.Attribute(ATTRIBUTE_ID).Value) == id).Value;
        }

        public int GetBrandId(BrandEnum brand)
        {
            return int.Parse(_xBrands.Root.Elements()
                                          .Single(element => element.Value == brand.ToString())
                                          .Attribute(ATTRIBUTE_ID).Value);
        }

        public int GetModelId(ModelEnum model)
        {
            return int.Parse(_xModels.Root.Elements()
                                          .Single(element => element.Value == model.ToString())
                                          .Attribute(ATTRIBUTE_ID).Value);
        }

        public int GetCarsCount()
        {
            return _xMain.Root.Elements().Count();
        }

        public int GetBrandsCount()
        {
            return _xBrands.Root.Elements().Count();
        }

        public double GetAveragePrice()
        {
            return GetCarsCount() > 0 ? GetTotalPrice(_xMain.Root.Elements().Select(car => double.Parse(car.Element(NAME_OF_PRICE).Value))) / GetCarsCount() : 0.0;
        }

        public double GetBrandAveragePrice(string brand)
        {
            var brands = _xMain.Root.Elements()
                                    .Where(car => GetBrandName(int.Parse(car.Element(NAME_OF_BRAND_ID).Value)) == brand)
                                    .Select(car => double.Parse(car.Element(NAME_OF_PRICE).Value));
            return brand.Count() > 0 ? GetTotalPrice(brands) / brand.Count() : 0.0 ;
        }

        public void AddCar(Car car)
        {
            CarConvertor carConvertor = new CarConvertor();
            CarDB convertedCar = carConvertor.Convert(car);
            _xMain.Root.Add
                (
                    new XElement
                        (
                            NAME_OF_CAR_DB,
                            new XElement(NAME_OF_BRAND_ID, convertedCar.BrandID),
                            new XElement(NAME_OF_MODEL_ID, convertedCar.ModelID),
                            new XElement(NAME_OF_PRICE, convertedCar.Price)
                        )
                );
        }
    }
}
