using DEV_2._1_Task.Enums;

namespace DEV_2._1_Task.Entitys
{
    public class Car
    {
        public BrandEnum Brand { get; private set; }
        public ModelEnum Model { get; private set; }
        public double Price { get; private set; }

        public Car(BrandEnum theBrand, ModelEnum theModel, double thePrice)
        {
            Brand = theBrand;
            Model = theModel;
            Price = thePrice;
        }

        public override string ToString()
        {
            return Brand.ToString() + " " + Model.ToString() + " " + Price.ToString();
        }
    }
}
