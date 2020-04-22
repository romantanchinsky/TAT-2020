using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DEV_2._1_Task.Entitys
{
    public class CarDB : IXmlSerializable
    {
        public int BrandID { get; private set; }
        public int ModelID { get; private set; }
        public double Price { get; private set; }

        public CarDB(int theBrandID, int theModelID, double thePrice)
        {
            BrandID = theBrandID;
            ModelID = theModelID;
            Price = thePrice;   
        }

        public CarDB()
        { }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == nameof(CarDB))
            {
                BrandID = int.Parse(reader.ReadElementString());
                ModelID = int.Parse(reader.ReadElementString());
                Price = double.Parse(reader.ReadElementString());
            }
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString(nameof(BrandID), BrandID.ToString());
            writer.WriteElementString(nameof(ModelID), ModelID.ToString());
            writer.WriteElementString(nameof(Price), Price.ToString());
        }
    }
}